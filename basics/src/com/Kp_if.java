package com;

public class Kp_if {
	public static void main(String[] args) {
		// ��Ԫ�����
		int a = 10;
		int b = 20;
		int c = 30;
		int d = 40;
		String str1 = (a > b) ? "a��" : (a == b) ? "���" : "b��";
		System.out.println(str1);
		int max1 = (a > b) ? a : b;
		int max2 = (max1 > c) ? max1 : c;

		// һ��Ľ������贴���м���ʱ����
		// �������� ���ǣ��������ϴ�ʱ������־�����ʧ
		a = a + b;
		b = a - b;
		a = a - b;
		System.out.println("b:" + b);
		System.out.println("a:" + a);

		// ����֮��
		c = c ^ d;
		d = c ^ d;// (c^d)^d==c
		c = c ^ d;// (c^d)^c==d
		System.out.println("c:" + c);
		System.out.print("d:" + d);

	}

}
