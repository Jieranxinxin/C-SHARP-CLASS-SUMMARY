package com;

import java.util.Scanner;

public class Task_shuixianhua {
	public static void main(String[] args) {
		
		 int num,a,b,c,sum;
		 
		 System.out.println("������һ����λ����������");
		 while(true) {
		 Scanner input=new Scanner(System.in);
		 num=input.nextInt();
		 
		 
		 if(num>=100&&num<=999) {
		 a=num/100;
		 b=num/10%10;
		 c=num%10;
		 
		 sum=a*a*a+b*b*b+c*c*c;
		 if(sum==num) {
			 System.out.println(num+"��ˮ�ɻ���");
		 }else {
			 System.out.print(num+"����ˮ�ɻ���");
		 }
		 break;
		 }else {
			 System.out.println("���������������������룺");
			 continue;
		 }
		 }
	}
}
