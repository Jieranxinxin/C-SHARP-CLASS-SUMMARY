package com.xinxin0;

import java.util.Scanner;

public class Test5 {
	public static void main(String[] args) {
		Vehicle v=new Vehicle();
		v.speed=1;
		v.type="����";
		System.out.println("������"+v.type+"\n"+"��ʱ�����ٶ�Ϊ��"+v.speed);
		v.move();
		Scanner in=new Scanner(System.in);
		System.out.println("��������ϣ�����ӵ��ٶȣ�");
		double a=in.nextInt();
		v.speedUp(a);
		System.out.println("��������ϣ�����ٵ��ٶȣ�");
		double b=in.nextInt();
		v.speedDown(b);
	}
}

class Vehicle {
	double speed;
	String type;

	public void move() {
		System.out.println("������ʼ����");
		System.out.println("*********");

	}

	public void speedUp(double s) {// ����
		//System.out.println("������ʼ����,ÿ�μ�1");
		this.speed =speed+s;
		System.out.println("��ʱ���ٺ�Ϊ��" + speed);
	}

	public void speedDown(double s) {// ����
		
		this.speed = speed-s;
		if(speed<0) {
			System.out.println("���ٺ��ٶ�С��0��������ѡ��");
		}
		else {
		System.out.println("��ʱ���ٶ�Ϊ��" + speed);
		}
	}

}