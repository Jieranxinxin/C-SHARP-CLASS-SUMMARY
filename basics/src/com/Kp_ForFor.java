package com;

import javax.print.attribute.standard.PrinterLocation;

public class Kp_ForFor {
	public static void main(String[] args) {
		/*
		 ��ӡ��
		 ���ѭ�������У��ڲ�ѭ��������
		 ****
		 ****
		 ****
		 */
		for(int i=1;i<4;i++) {
			for(int j=1;j<5;j++) {
				System.out.print("*");
			}
			System.out.print("\n");
		}
		/*
		 ��ӡ��
		 * 
		 * *
		 * * *
		 * * * *
		 */
		for(int i=1;i<5;i++) {
			for(int j=1;j<i+1;j++) {
				System.out.print("* ");
			}
			System.out.print("\n");
		}
		/*
		 ��ӡ��
		 * * * *
		 * * * 
		 * *
		 * 
		 */
		for(int i=0;i<4;i++) {
			for(int j=4;j>i;j--) {
				System.out.print("* ");
			}
			System.out.print("\n");
		}
		
		
		//��ӡ99�˷���
		for(int i=1;i<=9;i++) {
			
			for(int j=1;j<=i;j++) {
				System.out.print(j+"*"+i+"="+i*j+"\t");
			}
			System.out.println();
		}
		
		int[] num= {1,2,3,4,5,6};
		for(int a:num) {
			System.out.println(a);
		}
		
		
	}

}
