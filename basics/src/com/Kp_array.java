package com;

public class Kp_array {
	
	public static void main(String[] args) {
	//1.����һ������
	String[] names;
	//2.����ĳ�ʼ��
	//��һ��.��̬��ʼ��,��ʼ���͸����鸳ֵͬʱ����
	names=new String[] {"����Щ","�ſ���","jie"};
	System.out.println(names[1]);
	
	//�ڶ���.��̬��ʼ������ʼ���͸����鸳ֵ�ֿ�����
	//int scores ��    int[]
	int[] scores = new int[4];
	scores[0]=23;
	scores[1]=93;
	scores[3]=100;
	System.out.println(scores[3]);
	//��������
	for(int i=0;i<4;i++) {
		System.out.println(scores[i]);
		}
	//���д���ַ�ʽ
	for(int i=0;i<names.length;i++) {
		System.out.println(scores[i]);
	}
	}
}
