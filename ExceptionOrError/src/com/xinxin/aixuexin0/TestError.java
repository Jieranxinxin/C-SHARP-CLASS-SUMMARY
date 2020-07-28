package com.xinxin.aixuexin0;

public class TestError {
	public static void main(String[] args) {
		//栈的空间是有限的，若一直将String[] args  传给args
		//java.lang.StackOverflowError 栈溢出
		//main(args);	
		
		//数组实体在堆空间
		byte[] b=new byte[1024*1024*600];//[1024*1024*600]多字节
	}
}
