package com;

public class Kp_array {
	
	public static void main(String[] args) {
	//1.声明一个数组
	String[] names;
	//2.数组的初始化
	//第一种.静态初始化,初始化和给数组赋值同时进行
	names=new String[] {"长了些","张可新","jie"};
	System.out.println(names[1]);
	
	//第二种.动态初始化，初始化和给数组赋值分开进行
	//int scores 与    int[]
	int[] scores = new int[4];
	scores[0]=23;
	scores[1]=93;
	scores[3]=100;
	System.out.println(scores[3]);
	//遍历数组
	for(int i=0;i<4;i++) {
		System.out.println(scores[i]);
		}
	//最好写这种方式
	for(int i=0;i<names.length;i++) {
		System.out.println(scores[i]);
	}
	}
}
