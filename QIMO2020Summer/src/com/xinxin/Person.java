package com.xinxin;

public abstract class Person {
	public abstract void eat ();
	public abstract void sleep();

}
class Student extends Person {
	
	public void eat() {
		System.out.println("ѧ���Է�");
	}

	public void sleep() {
		System.out.println("ѧ��˯��");
	}
	
}
class Worker extends Person{
	
	public void eat() {
		System.out.println("���˳Է�");
	}

	public void sleep() {
		System.out.println("����˯��");
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