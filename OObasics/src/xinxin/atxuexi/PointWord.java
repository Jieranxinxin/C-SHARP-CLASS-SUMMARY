package xinxin.atxuexi;
/*
 * this:
 * 1.可以用来修饰属性、方法、构造器
 * 2.this理解为当前对象、当前正在创建的对象(谁调我，谁就是当前对象
 * 
 * )
 * 
 * 
 * 
 */

public class PointWord {
	public static void main(String[] args) {
		Person P1=new Person();
		P1.setAge(9);
		P1.setName("xin");

		P1.info();
	}

}
class Person{
	private String name;
	private int age;
	
	//构造器
	//空参
	public Person(){
		
	}
	//重载
	/*
	public Person(String n) {
		name=n;
	}
	
	*/
	public Person(String name) {
		this.name=name;
	}
	
	public Person(String n,int m) {
		name=n;
		age=m;
	}
	
	public void setName(String n) {
		name=n;
	}
	public String getName() {
		return name;
	}
	public void setAge(int m) {
		age=m;
	}
	public int getAge() {
		return age;
	}
	
	public void eat() {
		System.out.println("吃饭");
	}
	public void sleep() {
		System.out.println("睡觉");
	}
	public void info() {
		System.out.println("name:"+name+"age:"+age);
	}
}