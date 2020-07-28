package xinxin.atxuexi;
/*
 * 一、面向对象的特征一，封装与隐藏
 * 面临的问题：当创建了类的对象以后，如果直接通过“对象.属性”的方式对相对应的对象属性赋值的话，
 * 可能会出现不满足实际情况的意外，我们考虑不让对象来直接作用属性，而是通过“对象。方法”的形式，
 * 来控制对象对属性的访问，实际情况中，对属性的要求就可以通过方法来实现
 * 
 * 解决方法：（封装性的思想）将类的属性私有化，提供公共的方法（setter&getter）来实现调用
 * 
 * 二、权限修饰符   修饰类、属性、方法
 * public   
 * private 修饰的属性只能在本类中调用，出了此类不可调用
 * 缺省   啥都没有   类内部 同一个包 1
 * protected  类内部 同一个包 子类
 * 
 * 修饰类的权限有：public 缺省
 * 
 * 注：权限从大到小：public protated 缺省default   private
 */
public class Tesk_Animal {
	public static void main(String[] args) {
		Animal_1 a1=new Animal_1();
		a1.name="xinxin";
		System.out.println();

		//a1.legs=3;
		a1.setLegs(4);
		a1.info();
		a1.eat();	
	}

}
class Animal_1 {
	String name;
	int legs;
	
	//方法
	public void eat() {
		System.out.println("动物进食");
	}
	public void sleep() {
		System.out.println("动物睡觉");
	}
	public void info() {
		System.out.println("name:"+name+"legs:"+legs);
	}
	
	public void setLegs(int l) {
		if(l>0&&l%2==0) {
			legs=l;
		}else {
			System.out.println("输入数据有误");
		}
	}
	public int getLegs() {
		return legs;
	}
	
}