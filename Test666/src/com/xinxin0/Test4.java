package com.xinxin0;

public class Test4 {
	public static void main(String[] args) {
		Person p = new Student();
		Person p1 = new Work();
		p.eat();
		p.sleep();
		p1.eat();
		p1.sleep();
	}

}

abstract class Person {
	public abstract void eat();

	public abstract void sleep();

}

class Student extends Person {

	@Override
	public void eat() {
		System.out.println("ѧ���Է�");
	}

	@Override
	public void sleep() {
		System.out.println("ѧ��˯��");

	}

}

class Work extends Person {

	@Override
	public void eat() {
		System.out.println("���˳Է�");

	}

	@Override
	public void sleep() {
		System.out.println("����˯��");

	}

}