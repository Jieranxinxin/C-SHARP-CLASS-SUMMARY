package xinxinatxuexi;
/*
 * static，静态的，可以用来修饰属性、方法、（代码块）初始化块、内部类，不能修饰构造器
 * 
 * 修饰属性（类变量）：随着实例加载而加载，而且独一份，可以通过类直接调用，实例变量却不行
 * 类变量的加载早于对象
 * 类变量存在静态域中
 * 
 * 修饰方法（类方法）：
 * 1.随着类的加载而加载，在内存中独一份
 * 2.直接可以通过  类.类方法  的方式调用    普通的方法只能通过对象. 调
 * 3.静态方法内部可以调用静态的方法和属性，而不能调用非静态的
 * 4.静态方法在 内存中出现早，同时，被回收也要晚，生命周期长
 * 
 * 注：静态方法里不可以有  this\super关键字
 */
public class TestSportsMan {
	public static void main(String[] args) {
		SportsMan s1=new SportsMan("xinxin",12);
		SportsMan s2=new SportsMan("wang",21);
		
		s1.nation="China";
		
		
		System.out.println(s1);
		System.out.println(s2);

		//SportsMan.show()
		s1.show1();

	}

}
//利用源码，生成字段构造器
class SportsMan {
	//实例变量，属于对象的那个，随着对象的创建而被加载
	String name;
	int age;
	//类变量
	static String nation;
	public SportsMan(String name, int age) {
		super();
		this.name = name;
		this.age = age;
		SportsMan.show2();
		
	}
	@Override
	public String toString() {
		return "SportsMan [name=" + name + ", age=" + age + ", nation=" + nation + "]";
	}
	
	public void show1() {
		System.out.println("我是一个普通的来自中国的运动员");
	}
	public static void show2() {
		System.out.println("我是一个安静的来自中国的运动员");
		show3();
	}
	public static void show3() {
		System.out.println("我是静态方法");
	}
}