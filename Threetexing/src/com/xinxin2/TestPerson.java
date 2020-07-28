package com.xinxin2;
/*
 * 面向对象的特性三：多态性
 * 1.多态性指的是什么？多态性，可以理解为一个事物的多种表现形态
 *   1》方法的重载和重写2》子类对象的多态性
 * 2.子类对象的多态性使用的前程：1》要有类的继承2》要有子类对父类方法的重写
 * 3.程序运行分为编译状态和运行状态
 * 对于多态性来说，编译时，“看左边”，将此引用变量看成父类的对象
 * 运行时，“看右边”，关注于真正对象的实体，子类的对象，那么执行的方法就是子类重写的
 */
public class TestPerson {
public static void main(String[] args) {
	Person p=new Person();
	p.eat();
	p.sleep();
	
	Man m=new Man();
	m.eat();
	m.sleep();
	
	//子类对象的多态性,父类的引用指向子类对象
	Person p1=new Man();
	//虚拟方法调用，通过父类的引用指向子类的对象实体，当调用方法时，
	//实际执行的时子类重写父类的方法
	p1.eat();
	p1.sleep();
	
	Person p2=new Woman();//向上转型
	p2.eat();
	p2.sleep();
	//这样只能调父子类中都有的，非得调，向下转型
	Woman w=(Woman)p2;
	w.shoping();//使用强制符
	/*
	 这种只能编译，运行出错
	Woman w1=(Woman)p1;
	w.shoping();
	强转可以，但是两个类之间无关系，运行就会出错
	这种情况要小心
	*/
	//instanceof  格式  对象a instanceof 类A,判断对象a是否是类A的一个实例
	//是的话，返回true,否则返回false
	//若a是A类的实例，那么a也一定是A类父类的实例
	if(p1 instanceof Woman) {
		Woman w1=(Woman)p1;
		w1.shoping();
	}
	if(p1 instanceof Man) {
		Man m1=(Man)p1;
		m1.entertainment();
	}
	if(p1 instanceof Person) {
		System.out.println("nihao");
	}
	
	
	
	
	
	
}
}



