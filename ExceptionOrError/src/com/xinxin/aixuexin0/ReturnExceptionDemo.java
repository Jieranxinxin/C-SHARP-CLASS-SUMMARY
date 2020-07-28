package com.xinxin.aixuexin0;

public class ReturnExceptionDemo {
	static void methodA() {
		try {
			System.out.println("进入方法A");
			System.out.println("进入方法A");
			throw new RuntimeException("制造异常");
		} finally{
			System.out.println("用方法A的finally");
		}
	}
	static void methodB() {
		try {
			System.out.println("进入方法B");
			System.out.println("进入方法B");
			return;
		} finally {
			System.out.println("用方法B的finally");
		}
	}
	
	public static void main(String[] args) {
		try {
			methodA();
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
		methodB();
	}

}
