﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using XA_DataSetLib;

namespace XingAPINet
{
    public partial class XingReal : IDisposable
    {
        protected XARealClass _xaReal;
        bool _disposed;
        EventWaitHandle _ewh_ReadSync = new EventWaitHandle(false, EventResetMode.ManualReset);
        bool _advise;

        public event EventHandler<RealDataArgs> DataArrived;

        public XingReal(string resFileCode)
        {
            _xaReal = new XARealClass();
            _xaReal.ResFileName = $".\\Res\\{resFileCode}.res";
            _xaReal.ReceiveRealData += _xaReal_ReceiveRealData;
        }

        public bool WaitForData(int milliseconds = 1000)
        {
            _ewh_ReadSync.Reset();

            int elapsedUnit = 16;
            while (true)
            {
                Application.DoEvents();
                if (_ewh_ReadSync.WaitOne(elapsedUnit) == true)
                {
                    break;
                }

                milliseconds -= elapsedUnit;
                if (milliseconds <= 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void _xaReal_ReceiveRealData(string szTrCode)
        {
            _ewh_ReadSync.Set();
            DataArrived?.Invoke(this, new RealDataArgs(szTrCode));
        }

        public void Advise()
        {
            _advise = true;
            _xaReal.AdviseRealData();
        }

        public void Unadvise()
        {
            _advise = false;
            _xaReal.UnadviseRealData();
        }

        public void SetFieldData(string blockName, string fieldName, string value)
        {
            _xaReal.SetFieldData(blockName, fieldName, value);
        }

        public string GetFieldData(string blockName, string fieldName)
        {
            return _xaReal.GetFieldData(blockName, fieldName);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed == false)
            {
                if (disposing == true)
                {
                    if (_xaReal != null)
                    {
                        if (_advise == true)
                        {
                            _xaReal.UnadviseRealData();
                            _advise = false;
                        }

                        Marshal.ReleaseComObject(_xaReal);
                        _xaReal = null;
                    }
                }

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
