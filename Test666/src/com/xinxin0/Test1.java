//package com.xinxin0;
//
//public class Test1 {
//	public static void main(String[] args) {
//		Person p = new Person();
//		Car c = new Car();
//		Bird b = new Bird();
//
//		p.start();
//		p.run();
//		p.stop();
//		p.dance();
//
//	}
//}
//
//interface Runner {
//	abstract void start();
//
//	abstract void run();
//
//	abstract void stop();
//}
//
//class Person implements Runner {
//
//	@Override
//	public void start() {
//		System.out.println("��Ҫ��ʼ����");
//	}
//
//	@Override
//	public void run() {
//		System.out.println("��������");
//	}
//
//	@Override
//	public void stop() {
//		System.out.println("�����ܲ�ֹͣ");
//	}
//
//	public void dance() {
//		System.out.println("����������Ӵ");
//	}
//
//}
//
//class Car implements Runner {
//
//	@Override
//	public void start() {
//		System.out.println("���ԼӺ����ţ�׼����ʼ");
//	}
//
//	@Override
//	public void run() {
//		System.out.println("�����ڰ�·�ϱ���");
//	}
//
//	@Override
//	public void stop() {
//		System.out.println("����ͣ��·��");
//	}
//
//	public void fillFuel() {
//		System.out.println("�������ڼ���վ���ͣ����Ժ�");
//	}
//
//	public void crack() {
//		System.out.println("O��NO����̥����");
//	}
//}
//
//class Bird implements Runner {
//
//	@Override
//	public void start() {
//		System.out.println("�����ۣ����߷�");
//	}
//
//	@Override
//	public void run() {
//		System.out.println("С���ų���������");
//	}
//
//	@Override
//	public void stop() {
//		System.out.println("�������֦����Ϣ");
//	}
//
//	public void fly() {
//		System.out.println("�������������");
//	}
//
//}
