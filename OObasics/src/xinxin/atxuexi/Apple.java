package xinxin.atxuexi;

public class Apple {

	String color ="Red";
	static int count=120;//静态成员变量数量
	final boolean MATRUE=true;
	
	int num;
	float price;
	
	public Apple () {
		num=10;
		price=5.2f;
	}
	
	public static void main(String[] args) {
		System.out.println(Apple.count);//静态变量可以通过类名直接访问
		Apple apple = new Apple();//创建一个Apple对象
		System.out.println(apple.color);
		System.out.println(apple.MATRUE);
		
		Apple apple1=new Apple();
		System.out.println("苹果的数量： "+apple.num+"\n"+"苹果的价格："+apple.price);

		
	}
	
}
