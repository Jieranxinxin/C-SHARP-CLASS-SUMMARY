package com.xinxin.aixuexin0;
/*
 * 1.手动的抛出一个异常的例子
 * 2.抛出的异常类型，若是RuntimeException,可以不显示的处理
 * 若是一个Exception,必须要显示的处理
 * 
 */
public class TestCirlce {
	public static void main(String[] args) {
		Circle c1=new Circle(2.1);
		Circle c2=new Circle(2.1);
		System.out.println(c1.compareTo(c2));
		System.out.println(c1.compareTo(new String("AA")));
	}

}
class Circle{
	private double radius;
	
	public double getRadius() {
		return radius;
	}
	
	public void setRadius(double radius) {
		this.radius=radius;
	}
	
	//带参构造器
	public Circle(double radius) {
		super();
		this.radius=radius;
	}
	
	//比较两个圆半径的大小  
	//Object 是 Java 类库中的一个特殊类，也是所有类的父类。
	//当一个类被定义后，如果没有指定继承的父类，那么默认父类就是 Object 类
	public int compareTo(Object obj) {
		if(this==obj) {
			return 0;
		}
		//instanceof 运算符是用来在运行时指出对象是否是特定类的一个实例
		//通过返回一个布尔值来指出，这个对象是否是这个特定类或者是它的子类的一个实例。
		else if(obj instanceof Circle) {
			//把obj转化成圆
			Circle c=(Circle)obj;
			if(this.radius>c.radius) {
				return 1;
			}else if(this.radius==c.radius) {
				return 0;
			}else {
				return -1;
			}
		}else {
			//return -2;
			//手动的抛出异常
			throw new RuntimeException("传入的类型有误");
		}
	}
	
	
	
	
	
	
}