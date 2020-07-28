package com;

import java.util.Scanner;

public class Task_compare_three_number {
	public static void main(String[] args) {
		
		int a,b,c;
		System.out.println("请输入整数a:");
		Scanner input = new Scanner(System.in);
		a=input.nextInt();
		
		System.out.println("请输入整数b:");
		Scanner input1 = new Scanner(System.in);
		b=input1.nextInt();
		
		System.out.println("请输入整数c:");
		Scanner input2 = new Scanner(System.in);
		c=input2.nextInt();
		
		
		if(a>b) {
			if(b>c) {
			System.out.println(c+"<"+b+"<"+a);
			}else {
			System.out.println(b+"<"+c+"<"+a);
			}
			
		}else if(b>a) {
			
			if(a>c) {
			System.out.println(c+"<"+a+"<"+b);
			}else {
			System.out.println(a+"<"+c+"<"+b);
			}
			
		}else if(c>a) {
			
			if (a>b) {
			System.out.println(b+"<"+a+"<"+c);
			}else {
			System.out.println(a+"<"+b+"<"+c);
			}
			
		}

	}
}