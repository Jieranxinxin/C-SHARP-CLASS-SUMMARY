package com.xinxin.aixuexin0;

public class TestError {
	public static void main(String[] args) {
		//ջ�Ŀռ������޵ģ���һֱ��String[] args  ����args
		//java.lang.StackOverflowError ջ���
		//main(args);	
		
		//����ʵ���ڶѿռ�
		byte[] b=new byte[1024*1024*600];//[1024*1024*600]���ֽ�
	}
}
