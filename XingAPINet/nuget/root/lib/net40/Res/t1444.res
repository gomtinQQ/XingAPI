BEGIN_FUNCTION_MAP
	.Func,시가총액상위(t1444),t1444,attr,block,headtype=A;
	BEGIN_DATA_MAP
	t1444InBlock,기본입력,input;
	begin
		업종코드,upcode,upcode,char,3;
		IDX,idx,idx,long,4;
	end
	t1444OutBlock,출력,output;
	begin
		IDX,idx,idx,long,4;
	end
	t1444OutBlock1,출력1,output,occurs;
	begin
		종목코드,shcode,shcode,char,6;
		종목명,hname,hname,char,20;
		현재가,price,price,long,8;
		전일대비구분,sign,sign,char,1;
		전일대비,change,change,long,8;
		등락율,diff,diff,float,6.2;
		거래량,volume,volume,long,12;
		거래비중,vol_rate,vol_rate,float,6.2;
		시가총액,total,total,long,12;
		비중,rate,rate,float,6.2;
		외인비중,for_rate,for_rate,float,6.2;
	end
	END_DATA_MAP
END_FUNCTION_MAP

