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
		System.out.println("学生吃饭");
	}

	@Override
	public void sleep() {
		System.out.println("学生睡觉");

	}

}

class Work extends Person {

	@Override
	public void eat() {
		System.out.println("工人吃饭");

	}

	@Override
	public void sleep() {
		System.out.println("工人睡觉");

	}

}