package com;

public class  ToHex
	{
		public static void main(String[] args) 
		{
			toHex_array(-60);//���������Ը�������ʮ�����ơ�
			//System.out.println("Hello World!");
		}
		//�ǲ��������ͨ�ķ��������ص�����
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
			for(int i=0;i<8;i++){   //ת��8λʮ������
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
	**********************�������ַ��������ò������ʵ������ת����*****************************
	*/
	 
		//��StringBuffer���洢
		public static void toHex_table( int num){
			char[] chs={'0','1','2','3','4',
				        '5','6','7','8','9',
				        'A','B','C','D','E',
				        'F'};//ע��Ҫ�ӡ�0����ʼ����������������chs[1]='1'��
			StringBuffer sb=new StringBuffer();
			for(int i=0;i<8;i++){
				int temp=num&15;
				//System.out.print(chs[temp]);
				sb.append(chs[temp]);
				num=num>>>4;
			}
			System.out.print(sb.reverse());
		}
	 
		//���������洢
		public static void toHex_array( int num){
			char[] chs={'0','1','2','3','4',
				        '5','6','7','8','9',
				        'A','B','C','D','E',
				        'F'};//ע��Ҫ�ӡ�0����ʼ����������������chs[1]='1'��
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
