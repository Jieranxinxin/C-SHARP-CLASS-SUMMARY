package com.xinxin0;
/*
 * �ӿ�������ʵ����֮��Ҳ���ڶ�̬��
 * 
 * 
 */
public class TestInterface1 {
	public static void main(String[] args) {
		Duck d=new Duck();
		TestInterface1.test1(d);
		TestInterface1.test2(d);
		TestInterface1.test3(d);
	}
	//��̬
	
	//�ӿڵ�����   �����޹�����������������
	public static void test1(Runner r) {//Runner r=new Duck();
		r.run();//���ⷽ������
	}
	public static void test2(Swimmer s) {//Swimmer r=new Duck();
		s.swim();
	}
	public static void test3(Flier f) {
		f.fly();
	}

}
interface Runner{
	public abstract void run();
}
interface Swimmer{
	void swim();
}
interface Flier{
	void fly();
}
class Duck implements Runner,Swimmer,Flier{

	@Override
	public void fly() {
System.out.println("I can fiy");		
	}

	@Override
	public void swim() {
		System.out.println("I can swim");		
		
	}

	@Override
	public void run() {
		System.out.println("I can run");		
		
	}
	
}


