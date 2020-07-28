package com;

public class  ToHex
	{
		public static void main(String[] args) 
		{
			toHex_array(-60);//查表法可以针对负数求其十六进制。
			//System.out.println("Hello World!");
		}
		//非查表法（最普通的方法）。重点在于
		/*
				temp=num&15;
				if(temp>9)
					sb.append((char)(temp-10+'A'));
				else
					sb.append(temp);
				num=num>>>4;
		*/
		public static void toHex(int num){
			StringBuffer sb=new StringBuffer();
			int temp; 
			for(int i=0;i<8;i++){   //转成8位十六进制
				temp=num&15;
				if(temp>9)
					sb.append((char)(temp-10+'A'));
				else
					sb.append(temp);
				num=num>>>4;
			}
			System.out.print(sb.reverse());
		}
	/*
	**********************下面两种方法都是用查表法进行实现数制转换的*****************************
	*/
	 
		//用StringBuffer来存储
		public static void toHex_table( int num){
			char[] chs={'0','1','2','3','4',
				        '5','6','7','8','9',
				        'A','B','C','D','E',
				        'F'};//注意要从‘0’开始！！这样才能满足chs[1]='1'。
			StringBuffer sb=new StringBuffer();
			for(int i=0;i<8;i++){
				int temp=num&15;
				//System.out.print(chs[temp]);
				sb.append(chs[temp]);
				num=num>>>4;
			}
			System.out.print(sb.reverse());
		}
	 
		//用数组来存储
		public static void toHex_array( int num){
			char[] chs={'0','1','2','3','4',
				        '5','6','7','8','9',
				        'A','B','C','D','E',
				        'F'};//注意要从‘0’开始！！这样才能满足chs[1]='1'。
			char[] arr=new char[8];
			int i=arr.length;
			while(num!=0){
				int temp=num&15;
				arr[--i]=chs[temp];
				num=num>>>4;
			}
			for(int j=i;j<arr.length;j++)
			System.out.print(arr[j]);
		}
	}	
