BEGIN_FUNCTION_MAP
	.Func,ETF일별추이(t1903),t1903,attr,block,headtype=A;
	BEGIN_DATA_MAP
	t1903InBlock,기본입력,input;
	begin
		단축코드,shcode,shcode,char,6;
		일자,date,date,char,8;
	end
	t1903OutBlock,출력,output;
	begin
		일자,date,date,char,8;
		종목명,hname,hname,char,20;
		업종지수명,upname,upname,char,20;
	end
	t1903OutBlock1,출력1,output,occurs;
	begin
		일자,date,date,char,8;
		현재가,price,price,long,8;
		전일대비구분,sign,sign,char,1;
		전일대비,change,change,long,8;
		누적거래량,volume,volume,float,12;
		NAV대비,navdiff,navdiff,float,9.2;
		NAV,nav,nav,float,9.2;
		전일대비,navchange,navchange,float,9.2;
		추적오차,crate,crate,float,9.2;
		괴리,grate,grate,float,9.2;
		지수,jisu,jisu,float,8.2;
		전일대비,jichange,jichange,float,8.2;
		전일대비율,jirate,jirate,float,8.2;
	end
	END_DATA_MAP
END_FUNCTION_MAP

