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
	case 9:System.out.println("A�ȼ�,����Ŷ��");break;
	case 8:System.out.println("B�ȼ�,���У�����Ŷ��");break;
	case 7:System.out.println("C�ȼ�,you can��");break;
	case 6:System.out.println("D�ȼ�,�����ˣ�");break;	
	default:System.out.println("E�ȼ�,���Ǳ���Ƿ��ţ�");break;}
	break;
	}else {
			System.out.println("������������,����������:");
			continue;// outer
	} 
	
	}
}
}