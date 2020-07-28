package com.xinxin4;
/*
 * 类的第五个成员，内部类
 * 1.相当于说，我们可以在类的内部在定义类，
 * 2.内部类的分类    成员内部类(声明在类内部方法外)and局部内部类
 * 3成员内部类
 *   3.1是外部类的一个成员
 *   1>可以有修饰符（4个）
 *   2>static final
 *   3>可以调用外部类的属性方法
 *   
 *   3.2具体类的特点
 *   1>abstract
 *   2>还可以在其内部定义属性、方法、构造器
 * 4.局部内部类
 * 
 * 5.关于内部类，我们需要掌握以下三点
 * ①如何创建成员内部类的对象（如：创建Bird类和Dog类的对象）
 * ②如何区别调用外部类、内部类的变量（特别是变量重名时）
 * ③局部内部类的使用
 * 
 */
public class TestInnerClass {
public static void main(String[] args) {
	//因为Dog是静态的，所以可以直接通过Person调Dog的构造器
	//创建静态内部类的对象，可以直接通过外部类调用静态内部类的构造器
	Person.Dog d=new Person.Dog();
	//应为Bird是非静态的，So不能通过外部类调用
	//Person.Bird b=new Person.Bird();
	
	//创建非静态的内部类的对象，必须先创建外部类的对象通过外部类
	//调用内部类的构造器
	Person p1=new Person();
	Person.Bird b=p1.new Bird();
	b.setName("a3");
	
}
}
class Person{
	String name="a1";
	int age;
	
	//成员内部类（非静态的static）
	class Bird
	{
		String name="a2";
		int id;
		
		public Bird() {
			
		}
		public void setName(String name) {
			System.out.println(name);//a3
			//this 指代setName所调的那个
			System.out.println(this.name);//a2
			System.out.println(Person.this.name);//a1
		}
		public void info() {
			show();
		}
	 }
	
	
	public void show(){
		
		}
	public void method1() {
		//方法当中的叫局部内部类
		class A{
			
		}
	}
	
	//成员内部类  （静态内部类）
	static class Dog{
		
	}
}