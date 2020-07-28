package com.xinxin;

import java.util.Scanner;

public class X_duiying_Y {
	public static void main(String[] args) {
		System.out.println("Please one num:");
		Scanner sc=new Scanner(System.in);
		int input=sc.nextInt();
		if(input>0) {
			System.out.println("y=1");
		}else if(input==0) {
			System.out.println("y=0");
		}else {
			System.out.println("y=-1");
		}
	}

}
