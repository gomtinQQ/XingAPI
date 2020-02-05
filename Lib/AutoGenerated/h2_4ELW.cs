﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRh2_InBlock : XingBlock
	{
		/// <summary>
		/// InBlock
		/// </summary>
		public const string _blockName = "InBlock";
		/// <summary>
		/// 입력
		/// </summary>
		public const string _blockDesc = "입력";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 입력
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// input
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XRh2_OutBlock : XingBlock
	{
		/// <summary>
		/// OutBlock
		/// </summary>
		public const string _blockName = "OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		public const string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 호가시간
		/// </summary>
		[XAQueryFieldAttribute("호가시간")]
		public string hotime;
		/// <summary>
		/// 시간외매도잔량
		/// </summary>
		[XAQueryFieldAttribute("시간외매도잔량")]
		public long tmofferrem;
		/// <summary>
		/// 시간외매수잔량
		/// </summary>
		[XAQueryFieldAttribute("시간외매수잔량")]
		public long tmbidrem;
		/// <summary>
		/// 시간외매도수량직전대비
		/// </summary>
		[XAQueryFieldAttribute("시간외매도수량직전대비")]
		public long pretmoffercha;
		/// <summary>
		/// 시간외매수수량직전대비
		/// </summary>
		[XAQueryFieldAttribute("시간외매수수량직전대비")]
		public long pretmbidcha;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 호가시간
			/// </summary>
			public const string hotime = "hotime";
			/// <summary>
			/// 시간외매도잔량
			/// </summary>
			public const string tmofferrem = "tmofferrem";
			/// <summary>
			/// 시간외매수잔량
			/// </summary>
			public const string tmbidrem = "tmbidrem";
			/// <summary>
			/// 시간외매도수량직전대비
			/// </summary>
			public const string pretmoffercha = "pretmoffercha";
			/// <summary>
			/// 시간외매수수량직전대비
			/// </summary>
			public const string pretmbidcha = "pretmbidcha";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.hotime,
			F.tmofferrem,
			F.tmbidrem,
			F.pretmoffercha,
			F.pretmbidcha,
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hotime"] = new XAQueryFieldInfo("char", hotime, hotime, "호가시간", (decimal)6);
			dict["tmofferrem"] = new XAQueryFieldInfo("long", tmofferrem, tmofferrem.ToString("d12"), "시간외매도잔량", (decimal)12);
			dict["tmbidrem"] = new XAQueryFieldInfo("long", tmbidrem, tmbidrem.ToString("d12"), "시간외매수잔량", (decimal)12);
			dict["pretmoffercha"] = new XAQueryFieldInfo("long", pretmoffercha, pretmoffercha.ToString("d12"), "시간외매도수량직전대비", (decimal)12);
			dict["pretmbidcha"] = new XAQueryFieldInfo("long", pretmbidcha, pretmbidcha.ToString("d12"), "시간외매수수량직전대비", (decimal)12);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hotime":
					this.hotime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tmofferrem":
					this.tmofferrem = fieldInfo.FieldValue.ParseLong("tmofferrem");
				break;

				case "tmbidrem":
					this.tmbidrem = fieldInfo.FieldValue.ParseLong("tmbidrem");
				break;

				case "pretmoffercha":
					this.pretmoffercha = fieldInfo.FieldValue.ParseLong("pretmoffercha");
				break;

				case "pretmbidcha":
					this.pretmbidcha = fieldInfo.FieldValue.ParseLong("pretmbidcha");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRh2_OutBlock FromQuery(XRh2_ query)
		{
			XRh2_OutBlock block = new XRh2_OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.hotime = query.GetFieldData(block.GetBlockName(), "hotime").TrimEnd('?'); // char 6
				block.tmofferrem = query.GetFieldData(block.GetBlockName(), "tmofferrem").ParseLong("tmofferrem"); // long 12
				block.tmbidrem = query.GetFieldData(block.GetBlockName(), "tmbidrem").ParseLong("tmbidrem"); // long 12
				block.pretmoffercha = query.GetFieldData(block.GetBlockName(), "pretmoffercha").ParseLong("pretmoffercha"); // long 12
				block.pretmbidcha = query.GetFieldData(block.GetBlockName(), "pretmbidcha").ParseLong("pretmbidcha"); // long 12
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 6

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hotime?.Length > 6) return false; // char 6
			if (tmofferrem.ToString().Length > 12) return false; // long 12
			if (tmbidrem.ToString().Length > 12) return false; // long 12
			if (pretmoffercha.ToString().Length > 12) return false; // long 12
			if (pretmbidcha.ToString().Length > 12) return false; // long 12
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XRh2_ : XingReal
	{
		/// <summary>
		/// h2_
		/// </summary>
		public const string _typeName = "h2_";
		/// <summary>
		/// ELW장전시간외호가잔량(h2)
		/// </summary>
		public const string _typeDesc = "ELW장전시간외호가잔량(h2)";
		/// <summary>
		/// false
		/// </summary>
		public const bool _attr = false;
		/// <summary>
		/// 0
		/// </summary>
		public const int _key = 0;
		/// <summary>
		/// 0
		/// </summary>
		public const int _group = 0;

		/// <summary>
		/// h2_
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ELW장전시간외호가잔량(h2)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// false
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// 0
		/// </summary>
		public int Key => _key;
		/// <summary>
		/// 0
		/// </summary>
		public int Group => _group;

		public XRh2_() : base("h2_") { }


		public bool SetBlock(XRh2_InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "shcode", block.shcode); // char 6

			return true;
		}

		public XRh2_OutBlock GetBlock()
		{
			XRh2_OutBlock instance = XRh2_OutBlock.FromQuery(this);
			return instance;

		}


	}

}
