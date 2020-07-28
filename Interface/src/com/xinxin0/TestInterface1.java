package com.xinxin0;
/*
 * 接口与具体的实现类之间也存在多态性
 * 
 * 
 */
public class TestInterface1 {
	public static void main(String[] args) {
		Duck d=new Duck();
		TestInterface1.test1(d);
		TestInterface1.test2(d);
		TestInterface1.test3(d);
	}
	//多态
	
	//接口的声明   其虽无构造器，但可以声明
	public static void test1(Runner r) {//Runner r=new Duck();
		r.run();//虚拟方法调用
	}
	public static void test2(Swimmer s) {//Swimmer r=new Duck();
		s.swim();
	}
	public static void test3(Flier f) {
		f.fly();
	}

}
interface Runner{
	public abstract void run();
}
interface Swimmer{
	void swim();
}
interface Flier{
	void fly();
}
class Duck implements Runner,Swimmer,Flier{

	@Override
	public void fly() {
System.out.println("I can fiy");		
	}

	@Override
	public void swim() {
		System.out.println("I can swim");		
		
	}

	@Override
	public void run() {
		System.out.println("I can run");		
		
	}
	
}


