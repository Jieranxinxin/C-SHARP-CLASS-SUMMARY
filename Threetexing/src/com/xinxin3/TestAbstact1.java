package com.xinxin3;
/*
 * abstract 不能用来修饰属性、构造器、private、final、static
 * 
 * 
 */
public class TestAbstact1 {

}
abstract class A{
	//不能用来修饰private，因为子类不能覆盖父类private的方法
	//private abstract int age();
	
	//不能用来修饰构造器,因为构造器不能重写
//	public abstract a1() {
//	}
	
//	final不让子类进行重写，而abstract是让子类进行重写
//	public abstract final void a2();
	
	
//	冲突
//	public abstract static void a3();
	
	
	
	
}