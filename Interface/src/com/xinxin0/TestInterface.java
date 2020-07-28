package com.xinxin0;

/*
 * 单继承多实现
 * 接口（interface）是与类并行的一个概念
 * 1.接口可以看成一个特殊的抽象类，是    常量  和  抽象方法  的一个集合.不能包含变量、一般方法
 * 2.接口无构造器
 * 3.接口定义的就是一种功能，此功能可以被类所实现（implements）.如：class C implements A
 * 4.实现接口的类，必须要重写所有的抽象方法，方可实例化，若没有重写所有的抽象方法，此类仍为一个抽象类
 * 5.类可以实现多个接口
 * 
 * 6.接口与接口之间是继承的关系  而且可以多继承

 *
 */
public class TestInterface {
	public static void main(String[] args) {
		System.out.println(A.I);
		// sysout
	}
}

interface A {
	// 1.接口里都是常量
	// static 说明是一个全局的 final 说明是一个常量
	public static final int I = 4;
	// 因为所有的常量都用 public static final 修饰，所以可以省略不写
	boolean FLAG = false;

	// 2.抽象方法 接口都是抽象方法
	// 其声明时都是public abstract ，SO可省略
	public abstract void method1();

	void method2();

}

// 不重写，加abstract 就是抽象的类
abstract class B implements A {

}

class D {

}

interface M {
	void method3();
}

// 重写方法 继承与实现并存
class C extends D implements A, M {
	public void method1() {

	}

	public void method2() {

	}

	public void method3() {

	}
}

// 接口接口之间可是实现多继承
interface J extends M, A {
	void method4();
}

class G implements J {

	@Override
	public void method3() {
		// TODO 自动生成的方法存根

	}

	@Override
	public void method4() {
		// TODO 自动生成的方法存根

	}

	@Override
	public void method1() {
		// TODO 自动生成的方法存根

	}

	@Override
	public void method2() {
		// TODO 自动生成的方法存根

	}

}