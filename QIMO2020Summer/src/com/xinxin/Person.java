package com.xinxin;

public abstract class Person {
	public abstract void eat ();
	public abstract void sleep();

}
class Student extends Person {
	
	public void eat() {
		System.out.println("学生吃饭");
	}

	public void sleep() {
		System.out.println("学生睡觉");
	}
	
}
class Worker extends Person{
	
	public void eat() {
		System.out.println("工人吃饭");
	}

	public void sleep() {
		System.out.println("工人睡觉");
	}
	
}
class Test{
	public static void main(String[] args) {
		Student stu=new Student();
		Worker wor=new Worker();
		stu.eat();
		stu.sleep();
		wor.eat();
		wor.sleep();
	}
	
}