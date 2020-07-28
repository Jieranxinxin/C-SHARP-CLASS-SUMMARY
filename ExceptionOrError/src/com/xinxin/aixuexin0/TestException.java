package com.xinxin.aixuexin0;

import java.util.InputMismatchException;
import java.util.Scanner;

import org.junit.jupiter.api.Test;

public class TestException {
	//一、异常的体系结构
	/*
	 * @Test的使用 该方法可以不用main方法调用就可以测试出运行结果，是一种测试方法 一般函数都需要有main方法调用才能执行
	 * 注意被测试的方法必须是public修饰的
	 */
	/*
	 * java.lang.Throwable
	 * 		|-----Error:错误，程序中不进行处理
	 * 		|-----Exception:异常，要求编写程序时需考虑，对这些异常的 处理
	 * 			|-----编译时异常   执行javac.exe出现异常
	 * 			|-----运行时异常   执行java.exe时出现异常
	 * 当执行一个程序时，如果出现异常，异常后的程序不再执行
	 */
	@Test
	public void test1() {
		Scanner s = new Scanner(System.in);
		// 从键盘上接受一个int型的值
		try {
		int i = s.nextInt();
		System.out.println(i);
		}catch(InputMismatchException e){
			System.out.println("类型不匹配");
		}

	}
	
	/*
	 * 常见运行时异常
	 * 1.数组下标越界异常：ArrayIndexOutOfBoundsException
	 */
	@Test
	public void test2() {
		try {
		int[] i=new int[10];
		System.out.println(i[10]);
		System.out.println(i[-10]);
		}catch(Exception e) {
			System.out.println("出现异常");
		}
	}
	/*
	 * 2.算数异常
	 * 
	 */
	@Test
	public void test3() {
		try {
			int i=10;
			System.out.println(i/0);
		} catch (Exception e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}
	}
	
	
}
