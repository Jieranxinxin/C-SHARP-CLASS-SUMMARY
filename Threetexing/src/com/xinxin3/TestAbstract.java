package com.xinxin3;

/*
 * abstract:抽象的，可以用来修饰类和方法
 * 
 * 1.abstract修饰类，抽象类
 * 1)不可被实例化
 * 2）有构造器  (凡是类都有构造器，因为就算父类是抽象类不可实例化，
 * 但是子类可以实例化)
 * 3）抽象方法所在的类一定是抽象类
 * 4）抽象类中可以有抽象方法
 * 
 * 2.修饰方法，抽象方法
 * 1)格式：没有方法体，包括{}，如public abstract void eat();
 * 2)抽象方法只保留方法的功能，而具体的执行，交给继承抽象父类的抽象子类
 * 由子类重写抽象方法
 * 3)若子类继承抽象类，并重写了所有的抽象方法，则此类是一个“实体类”，既可以实例化
 * 4）若子类继承抽象类，没有重写所有的抽象方法，意味着此类中仍有一个抽象方法
 * 则此类必须声明为抽象的！
 */
public class TestAbstract {
	public static void main(String[] args) {
		// Person p1=new Person();
		// p1.eat();
		Student s1 = new Student();
		s1.eat();
		Person p1 = new Student();// 多态
		p1.eat();
		//多态，不能点父类中没有的方法

	}
}

abstract class Creator {
	abstract void breath();
}

abstract class Person extends Creator {
	String name;

	// 只保留功能，没有具体的实现，实现交给具体的子类
	public abstract void eat();

	public abstract void walk();

	// 抽象类中的实体方法
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public Person() {

	}

	public Person(String name) {
		this.name = name;
	}
	public int Attitude(){
		return 0;
	}
}

class Student extends Person {
	public void eat() {
		System.out.println("学生吃饭");
	}

	public void walk() {
		System.out.println("学生走路");
	}

	@Override
	void breath() {
		System.out.println("学生不应该呼吸不新鲜的空气");
	}
	public int S_Attitude(){
		return 0;
	}
	
}

abstract class Worker extends Person {
	public void eat() {
		System.out.println("工人吃饭");
	}
	// public void walk() {
	// System.out.println("工人走路");
	// }

}
