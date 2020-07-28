package com.xinxin;
/*
 * 面向对象的特征二：继承性
 * 
 * 1》通过“clacc A extends B”实现类的继承
 *  子类 A 父类（或基类 SuperClass) B
 * 
 * 2》子类继承父类以后，父类声明的属性、方法、子类都可以获取的到
 *    明确：当父类中有私有属性或方法时 ，子类同样可以获取的到，只是由于封装性的
 *    设计，使得子类不可以直接调用
 *    子类除了继承获取父类的结构之外，还可以定义自己特有的部分
 *    
 *    extends:子类是对父类功能的拓展
 *    
 * 3》java的继承性，只允许单继承，只能继承一个父类，一个父类可以有多个子类
 * 4》子类父类是个相对的概念
 * 
 * 二、方法的重写在子类中          修饰符 返回值类型 方法名 （参数列表）{}
 * （方法重载是在同一个类当中）
 * 1.前提：有子类继承父类
 * 2.子类继承父类以后，若父类的方法对子类不适用，那么子类可以对父类的方法
 * 进行重写（override）覆盖
 * 3.重写的规则
 * 1》要求子类方法的“修饰符 返回值类型 方法名 （参数列表）”与父类的方法一样
 * 2》子类的方法的修饰符不能小于父类
 * 3》若父类方法抛异常，那么子类方法抛的异常类型不能大于父类
 * 4》子父类的方法必须同为static或同为非static的
 */
public class TestExtends {
public static void main(String[] args) {
	Student s=new Student();
	s.eat();
	
	Worker w=new Worker();
	w.sleep();
	Person p=new Person();
	p.eat();
	
	s.setAge(23);
	s.setName("xinxin");
	System.out.println(s.getName()+":"+s.getAge());
}
}
