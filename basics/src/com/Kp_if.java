package com;

public class Kp_if {
	public static void main(String[] args) {
		// 三元运算符
		int a = 10;
		int b = 20;
		int c = 30;
		int d = 40;
		String str1 = (a > b) ? "a大" : (a == b) ? "相等" : "b大";
		System.out.println(str1);
		int max1 = (a > b) ? a : b;
		int max2 = (max1 > c) ? max1 : c;

		// 一般的交换，需创建中间临时变量
		// 两数交换 但是，当两数较大时，会出现精度损失
		a = a + b;
		b = a - b;
		a = a - b;
		System.out.println("b:" + b);
		System.out.println("a:" + a);

		// 高手之法
		c = c ^ d;
		d = c ^ d;// (c^d)^d==c
		c = c ^ d;// (c^d)^c==d
		System.out.println("c:" + c);
		System.out.print("d:" + d);

	}

}
