package com;

import java.util.Scanner;

public class A1 {
public static void main(String[] args) {
	int x,a;
	System.out.print("Please your score:");
	//outer:
	while(true) {
	Scanner input=new Scanner(System.in);
	x=input.nextInt();
	
	if(x<=100 && x>=0) {
	a=x/10;
	switch(a) {
	case 10:
	case 9:System.out.println("A等级,不错哦！");break;
	case 8:System.out.println("B等级,还行，加油哦！");break;
	case 7:System.out.println("C等级,you can！");break;
	case 6:System.out.println("D等级,及格了！");break;	
	default:System.out.println("E等级,你的潜力非凡呐！");break;}
	break;
	}else {
			System.out.println("输入数据有误,请重新输入:");
			continue;// outer
	} 
	
	}
}
}