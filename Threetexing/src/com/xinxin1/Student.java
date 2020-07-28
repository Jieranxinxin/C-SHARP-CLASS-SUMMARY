package com.xinxin1;
/*
 * super:可以修饰属性、方法、构造器
 * 1>
 * 当子类与父类中有同名属性时，可以通过“super.此属性”显示的调用父类中的声明属性
 * 若想调用子类的同名的属性“this.此属性”
 * 2>
 * 当子类重写父类的方法以后，在子类中若想再显示的调用父类的被重写的方法，就需要调用
 * “super.方法”
 * 3>super修饰构造器    通过在子类中使用“super(形参列表）”来显示的调用父类中指定的构造器
 *   >在构造器内部，“super(形参列表)”必须声明在首行
 *   >在构造器内部，“this（形参列表）”或“super(形参列表)”只能出现一个
 *   >当构造器中，不显示的调用“this（形参列表）”或“super(形参列表)”
 *   其中一个，默认调用父类空参的构造器
 *   建议：设计一个类时，尽量提供一个空参的构造器
 *   根父类是object
 *   
 *   
 */
public class Student extends Person{
	protected String schoolName;
	int id=1002;//学号

	public Student() {
		//super();
	}
	
	public Student(String schoolName) {
		super ("keke",20);
		
		this.schoolName=schoolName;
	}

	public void show() {
		System.out.println(this.id);//1002
		System.out.println(super.id);//1001
		System.out.println(this.schoolName);
	}
}
