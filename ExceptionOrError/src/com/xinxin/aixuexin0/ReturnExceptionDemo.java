package com.xinxin.aixuexin0;

public class ReturnExceptionDemo {
	static void methodA() {
		try {
			System.out.println("���뷽��A");
			System.out.println("���뷽��A");
			throw new RuntimeException("�����쳣");
		} finally{
			System.out.println("�÷���A��finally");
		}
	}
	static void methodB() {
		try {
			System.out.println("���뷽��B");
			System.out.println("���뷽��B");
			return;
		} finally {
			System.out.println("�÷���B��finally");
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
