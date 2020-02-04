﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCEXAT11100InBlock1 : XingBlock
	{
		/// <summary>
		/// CEXAT11100InBlock1
		/// </summary>
		public const string _blockName = "CEXAT11100InBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// CEXAT11100InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAT11100InBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// In(*EMPTY*)
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
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string AcntNo;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("비밀번호")]
		public string Pwd;
		/// <summary>
		/// 선물옵션종목번호
		/// </summary>
		[XAQueryFieldAttribute("선물옵션종목번호")]
		public string FnoIsuNo;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char BnsTpCode;
		/// <summary>
		/// 유렉스가격조건구분코드
		/// </summary>
		[XAQueryFieldAttribute("유렉스가격조건구분코드")]
		public char ErxPrcCndiTpCode;
		/// <summary>
		/// 주문가격
		/// </summary>
		[XAQueryFieldAttribute("주문가격")]
		public double OrdPrc;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long OrdQty;

		public static class F
		{
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 비밀번호
			/// </summary>
			public const string Pwd = "Pwd";
			/// <summary>
			/// 선물옵션종목번호
			/// </summary>
			public const string FnoIsuNo = "FnoIsuNo";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpCode = "BnsTpCode";
			/// <summary>
			/// 유렉스가격조건구분코드
			/// </summary>
			public const string ErxPrcCndiTpCode = "ErxPrcCndiTpCode";
			/// <summary>
			/// 주문가격
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string OrdQty = "OrdQty";
		}

		public static string[] AllFields = new string[]
		{
			F.AcntNo,
			F.Pwd,
			F.FnoIsuNo,
			F.BnsTpCode,
			F.ErxPrcCndiTpCode,
			F.OrdPrc,
			F.OrdQty,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["ErxPrcCndiTpCode"] = new XAQueryFieldInfo("char", ErxPrcCndiTpCode, ErxPrcCndiTpCode.ToString(), "유렉스가격조건구분코드", (decimal)1);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("000000000000000.00"), "주문가격", (decimal)15.2);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "AcntNo":
					this.AcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Pwd":
					this.Pwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FnoIsuNo":
					this.FnoIsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "ErxPrcCndiTpCode":
					this.ErxPrcCndiTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "OrdQty":
					this.OrdQty = fieldInfo.FieldValue.ParseLong("OrdQty");
				break;


			}
		}

		public bool VerifyData()
		{
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (FnoIsuNo?.Length > 12) return false; // char 12
			// BnsTpCode char 1
			// ErxPrcCndiTpCode char 1
			// OrdPrc double 15.2
			if (OrdQty.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	public partial class XQCEXAT11100OutBlock1 : XingBlock
	{
		/// <summary>
		/// CEXAT11100OutBlock1
		/// </summary>
		public const string _blockName = "CEXAT11100OutBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// CEXAT11100OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAT11100OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// In(*EMPTY*)
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
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long RecCnt;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string AcntNo;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("비밀번호")]
		public string Pwd;
		/// <summary>
		/// 선물옵션종목번호
		/// </summary>
		[XAQueryFieldAttribute("선물옵션종목번호")]
		public string FnoIsuNo;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char BnsTpCode;
		/// <summary>
		/// 유렉스가격조건구분코드
		/// </summary>
		[XAQueryFieldAttribute("유렉스가격조건구분코드")]
		public char ErxPrcCndiTpCode;
		/// <summary>
		/// 주문가격
		/// </summary>
		[XAQueryFieldAttribute("주문가격")]
		public double OrdPrc;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long OrdQty;
		/// <summary>
		/// 주문조건가격
		/// </summary>
		[XAQueryFieldAttribute("주문조건가격")]
		public double OrdCndiPrc;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("통신매체코드")]
		public string CommdaCode;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 비밀번호
			/// </summary>
			public const string Pwd = "Pwd";
			/// <summary>
			/// 선물옵션종목번호
			/// </summary>
			public const string FnoIsuNo = "FnoIsuNo";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpCode = "BnsTpCode";
			/// <summary>
			/// 유렉스가격조건구분코드
			/// </summary>
			public const string ErxPrcCndiTpCode = "ErxPrcCndiTpCode";
			/// <summary>
			/// 주문가격
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string OrdQty = "OrdQty";
			/// <summary>
			/// 주문조건가격
			/// </summary>
			public const string OrdCndiPrc = "OrdCndiPrc";
			/// <summary>
			/// 통신매체코드
			/// </summary>
			public const string CommdaCode = "CommdaCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.Pwd,
			F.FnoIsuNo,
			F.BnsTpCode,
			F.ErxPrcCndiTpCode,
			F.OrdPrc,
			F.OrdQty,
			F.OrdCndiPrc,
			F.CommdaCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["Pwd"] = new XAQueryFieldInfo("char", Pwd, Pwd, "비밀번호", (decimal)8);
			dict["FnoIsuNo"] = new XAQueryFieldInfo("char", FnoIsuNo, FnoIsuNo, "선물옵션종목번호", (decimal)12);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["ErxPrcCndiTpCode"] = new XAQueryFieldInfo("char", ErxPrcCndiTpCode, ErxPrcCndiTpCode.ToString(), "유렉스가격조건구분코드", (decimal)1);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("000000000000000.00"), "주문가격", (decimal)15.2);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["OrdCndiPrc"] = new XAQueryFieldInfo("double", OrdCndiPrc, OrdCndiPrc.ToString("0000000000000000000000000.00000000"), "주문조건가격", (decimal)25.8);
			dict["CommdaCode"] = new XAQueryFieldInfo("char", CommdaCode, CommdaCode, "통신매체코드", (decimal)2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "AcntNo":
					this.AcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "Pwd":
					this.Pwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "FnoIsuNo":
					this.FnoIsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "ErxPrcCndiTpCode":
					this.ErxPrcCndiTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "OrdQty":
					this.OrdQty = fieldInfo.FieldValue.ParseLong("OrdQty");
				break;

				case "OrdCndiPrc":
					this.OrdCndiPrc = fieldInfo.FieldValue.ParseDouble("OrdCndiPrc");
				break;

				case "CommdaCode":
					this.CommdaCode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCEXAT11100OutBlock1 FromQuery(XQCEXAT11100 query)
		{
			XQCEXAT11100OutBlock1 block = new XQCEXAT11100OutBlock1();
			block.IsValidData = true;
			block.InvalidReason = "";
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				block.IsValidData = false;
				block.InvalidReason = query.ReceiveMessage;
				return block;
			}
			try
			{
				block.RecCnt = query.GetFieldData(block.GetBlockName(), "RecCnt", 0).ParseLong("RecCnt"); // long 5
				block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", 0).TrimEnd('?'); // char 20
				block.Pwd = query.GetFieldData(block.GetBlockName(), "Pwd", 0).TrimEnd('?'); // char 8
				block.FnoIsuNo = query.GetFieldData(block.GetBlockName(), "FnoIsuNo", 0).TrimEnd('?'); // char 12
				block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", 0).FirstOrDefault(); // char 1
				block.ErxPrcCndiTpCode = query.GetFieldData(block.GetBlockName(), "ErxPrcCndiTpCode", 0).FirstOrDefault(); // char 1
				block.OrdPrc = query.GetFieldData(block.GetBlockName(), "OrdPrc", 0).ParseDouble("OrdPrc"); // double 15.2
				block.OrdQty = query.GetFieldData(block.GetBlockName(), "OrdQty", 0).ParseLong("OrdQty"); // long 16
				block.OrdCndiPrc = query.GetFieldData(block.GetBlockName(), "OrdCndiPrc", 0).ParseDouble("OrdCndiPrc"); // double 25.8
				block.CommdaCode = query.GetFieldData(block.GetBlockName(), "CommdaCode", 0).TrimEnd('?'); // char 2

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNo?.Length > 20) return false; // char 20
			if (Pwd?.Length > 8) return false; // char 8
			if (FnoIsuNo?.Length > 12) return false; // char 12
			// BnsTpCode char 1
			// ErxPrcCndiTpCode char 1
			// OrdPrc double 15.2
			if (OrdQty.ToString().Length > 16) return false; // long 16
			// OrdCndiPrc double 25.8
			if (CommdaCode?.Length > 2) return false; // char 2

			return true;
		}
	}

	public partial class XQCEXAT11100OutBlock2 : XingBlock
	{
		/// <summary>
		/// CEXAT11100OutBlock2
		/// </summary>
		public const string _blockName = "CEXAT11100OutBlock2";
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		public const string _blockDesc = "Out(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// CEXAT11100OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CEXAT11100OutBlock2
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Out(*EMPTY*)
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
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long RecCnt;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public long OrdNo;
		/// <summary>
		/// 지점명
		/// </summary>
		[XAQueryFieldAttribute("지점명")]
		public string BrnNm;
		/// <summary>
		/// 계좌명
		/// </summary>
		[XAQueryFieldAttribute("계좌명")]
		public string AcntNm;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string IsuNm;
		/// <summary>
		/// 주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("주문가능금액")]
		public long OrdAbleAmt;
		/// <summary>
		/// 현금주문가능금액
		/// </summary>
		[XAQueryFieldAttribute("현금주문가능금액")]
		public long MnyOrdAbleAmt;
		/// <summary>
		/// 주문증거금
		/// </summary>
		[XAQueryFieldAttribute("주문증거금")]
		public long OrdMgn;
		/// <summary>
		/// 현금주문증거금
		/// </summary>
		[XAQueryFieldAttribute("현금주문증거금")]
		public long MnyOrdMgn;
		/// <summary>
		/// 주문가능수량
		/// </summary>
		[XAQueryFieldAttribute("주문가능수량")]
		public long OrdAbleQty;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string OrdNo = "OrdNo";
			/// <summary>
			/// 지점명
			/// </summary>
			public const string BrnNm = "BrnNm";
			/// <summary>
			/// 계좌명
			/// </summary>
			public const string AcntNm = "AcntNm";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string IsuNm = "IsuNm";
			/// <summary>
			/// 주문가능금액
			/// </summary>
			public const string OrdAbleAmt = "OrdAbleAmt";
			/// <summary>
			/// 현금주문가능금액
			/// </summary>
			public const string MnyOrdAbleAmt = "MnyOrdAbleAmt";
			/// <summary>
			/// 주문증거금
			/// </summary>
			public const string OrdMgn = "OrdMgn";
			/// <summary>
			/// 현금주문증거금
			/// </summary>
			public const string MnyOrdMgn = "MnyOrdMgn";
			/// <summary>
			/// 주문가능수량
			/// </summary>
			public const string OrdAbleQty = "OrdAbleQty";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.OrdNo,
			F.BrnNm,
			F.AcntNm,
			F.IsuNm,
			F.OrdAbleAmt,
			F.MnyOrdAbleAmt,
			F.OrdMgn,
			F.MnyOrdMgn,
			F.OrdAbleQty,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["OrdNo"] = new XAQueryFieldInfo("long", OrdNo, OrdNo.ToString("d10"), "주문번호", (decimal)10);
			dict["BrnNm"] = new XAQueryFieldInfo("char", BrnNm, BrnNm, "지점명", (decimal)40);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)50);
			dict["OrdAbleAmt"] = new XAQueryFieldInfo("long", OrdAbleAmt, OrdAbleAmt.ToString("d16"), "주문가능금액", (decimal)16);
			dict["MnyOrdAbleAmt"] = new XAQueryFieldInfo("long", MnyOrdAbleAmt, MnyOrdAbleAmt.ToString("d16"), "현금주문가능금액", (decimal)16);
			dict["OrdMgn"] = new XAQueryFieldInfo("long", OrdMgn, OrdMgn.ToString("d16"), "주문증거금", (decimal)16);
			dict["MnyOrdMgn"] = new XAQueryFieldInfo("long", MnyOrdMgn, MnyOrdMgn.ToString("d16"), "현금주문증거금", (decimal)16);
			dict["OrdAbleQty"] = new XAQueryFieldInfo("long", OrdAbleQty, OrdAbleQty.ToString("d16"), "주문가능수량", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "OrdNo":
					this.OrdNo = fieldInfo.FieldValue.ParseLong("OrdNo");
				break;

				case "BrnNm":
					this.BrnNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "AcntNm":
					this.AcntNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNm":
					this.IsuNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdAbleAmt":
					this.OrdAbleAmt = fieldInfo.FieldValue.ParseLong("OrdAbleAmt");
				break;

				case "MnyOrdAbleAmt":
					this.MnyOrdAbleAmt = fieldInfo.FieldValue.ParseLong("MnyOrdAbleAmt");
				break;

				case "OrdMgn":
					this.OrdMgn = fieldInfo.FieldValue.ParseLong("OrdMgn");
				break;

				case "MnyOrdMgn":
					this.MnyOrdMgn = fieldInfo.FieldValue.ParseLong("MnyOrdMgn");
				break;

				case "OrdAbleQty":
					this.OrdAbleQty = fieldInfo.FieldValue.ParseLong("OrdAbleQty");
				break;


			}
		}

		public static XQCEXAT11100OutBlock2 FromQuery(XQCEXAT11100 query)
		{
			XQCEXAT11100OutBlock2 block = new XQCEXAT11100OutBlock2();
			block.IsValidData = true;
			block.InvalidReason = "";
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				block.IsValidData = false;
				block.InvalidReason = query.ReceiveMessage;
				return block;
			}
			try
			{
				block.RecCnt = query.GetFieldData(block.GetBlockName(), "RecCnt", 0).ParseLong("RecCnt"); // long 5
				block.OrdNo = query.GetFieldData(block.GetBlockName(), "OrdNo", 0).ParseLong("OrdNo"); // long 10
				block.BrnNm = query.GetFieldData(block.GetBlockName(), "BrnNm", 0).TrimEnd('?'); // char 40
				block.AcntNm = query.GetFieldData(block.GetBlockName(), "AcntNm", 0).TrimEnd('?'); // char 40
				block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", 0).TrimEnd('?'); // char 50
				block.OrdAbleAmt = query.GetFieldData(block.GetBlockName(), "OrdAbleAmt", 0).ParseLong("OrdAbleAmt"); // long 16
				block.MnyOrdAbleAmt = query.GetFieldData(block.GetBlockName(), "MnyOrdAbleAmt", 0).ParseLong("MnyOrdAbleAmt"); // long 16
				block.OrdMgn = query.GetFieldData(block.GetBlockName(), "OrdMgn", 0).ParseLong("OrdMgn"); // long 16
				block.MnyOrdMgn = query.GetFieldData(block.GetBlockName(), "MnyOrdMgn", 0).ParseLong("MnyOrdMgn"); // long 16
				block.OrdAbleQty = query.GetFieldData(block.GetBlockName(), "OrdAbleQty", 0).ParseLong("OrdAbleQty"); // long 16

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (OrdNo.ToString().Length > 10) return false; // long 10
			if (BrnNm?.Length > 40) return false; // char 40
			if (AcntNm?.Length > 40) return false; // char 40
			if (IsuNm?.Length > 50) return false; // char 50
			if (OrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (MnyOrdAbleAmt.ToString().Length > 16) return false; // long 16
			if (OrdMgn.ToString().Length > 16) return false; // long 16
			if (MnyOrdMgn.ToString().Length > 16) return false; // long 16
			if (OrdAbleQty.ToString().Length > 16) return false; // long 16

			return true;
		}
	}

	public partial class XQCEXAT11100 : XingQuery
	{
		/// <summary>
		/// CEXAT11100
		/// </summary>
		public const string _typeName = "CEXAT11100";
		/// <summary>
		/// 유렉스 매수/매도주문
		/// </summary>
		public const string _typeDesc = "유렉스 매수/매도주문";
		/// <summary>
		/// CEXAT11100
		/// </summary>
		public const string _service = "CEXAT11100";
		/// <summary>
		/// B
		/// </summary>
		public const string _headType = "B";
		/// <summary>
		/// 이시종
		/// </summary>
		public const string _creator = "이시종";
		/// <summary>
		/// 2012/06/27 20:48:05
		/// </summary>
		public const string _createdDate = "2012/06/27 20:48:05";
		/// <summary>
		/// false
		/// </summary>
		public const bool _attr = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _block = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _signature = false;

		/// <summary>
		/// CEXAT11100
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 유렉스 매수/매도주문
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CEXAT11100
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 이시종
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2012/06/27 20:48:05
		/// </summary>
		public string CreatedDate => _createdDate;
		/// <summary>
		/// false
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// false
		/// </summary>
		public bool Block => _block;
		/// <summary>
		/// false
		/// </summary>
		public bool Encrypt => _encrypt;
		/// <summary>
		/// false
		/// </summary>
		public bool Signature => _signature;

		public XQCEXAT11100() : base("CEXAT11100") { }


		public bool SetFields(XQCEXAT11100InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "Pwd", 0, block.Pwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "FnoIsuNo", 0, block.FnoIsuNo); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "BnsTpCode", 0, block.BnsTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "ErxPrcCndiTpCode", 0, block.ErxPrcCndiTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdPrc", 0, block.OrdPrc.ToString("000000000000000.00")); // double 15.2
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdQty", 0, block.OrdQty.ToString("d16")); // long 16

			return true;
		}

		public XQCEXAT11100OutBlock1 GetBlock1()
		{
			XQCEXAT11100OutBlock1 instance = XQCEXAT11100OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCEXAT11100OutBlock2 GetBlock2()
		{
			XQCEXAT11100OutBlock2 instance = XQCEXAT11100OutBlock2.FromQuery(this);
			return instance;

		}


	}

}