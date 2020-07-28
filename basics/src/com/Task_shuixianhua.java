package com;

import java.util.Scanner;

public class Task_shuixianhua {
	public static void main(String[] args) {
		
		 int num,a,b,c,sum;
		 
		 System.out.println("请输入一个三位的正整数：");
		 while(true) {
		 Scanner input=new Scanner(System.in);
		 num=input.nextInt();
		 
		 
		 if(num>=100&&num<=999) {
		 a=num/100;
		 b=num/10%10;
		 c=num%10;
		 
		 sum=a*a*a+b*b*b+c*c*c;
		 if(sum==num) {
			 System.out.println(num+"是水仙花数");
		 }else {
			 System.out.print(num+"不是水仙花数");
		 }
		 break;
		 }else {
			 System.out.println("输入数据有误，请重新输入：");
			 continue;
		 }
		 }
	}
}
