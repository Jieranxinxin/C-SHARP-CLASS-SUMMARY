package com;

import java.util.Scanner;

public class T_202038 {
	public static void main(String[] args) {
		/*
		 * int sum=0;
		
		for(int i=1;i<101;i++) {
			if(i%10!=3) {
				sum+=i;
			}
		}
		System.out.println(sum);*/
		
		
		System.out.println("输入需要传入的数据(四位整数)：");
		Scanner input=new Scanner(System.in);
		int j=input.nextInt();
		int Fnum=(j/1000+5)%10;
		int Snum=(j/100%10+5)%10;
		int Tnum=(j/10%10+5)%10;
		int Lnum=(j%10+5)%10;
		
		int term1,term2;
		term1=Fnum;
		Fnum=Lnum;
		Lnum=term1;
		
		term2=Snum;
		Snum=Tnum;
		Tnum=term2;
		
		System.out.println(Fnum+""+Snum+""+Tnum+""+Lnum);
		
		
		

	}		
}
