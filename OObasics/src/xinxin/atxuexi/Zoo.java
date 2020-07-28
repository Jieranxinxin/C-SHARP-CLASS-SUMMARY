package xinxin.atxuexi;

public class Zoo {
	public static void main(String[] args) {
		//类的实例化
		Animal a1=new Animal();
		
		System.out.println("name:"+a1.name+"age:"+a1.age);
		
		System.out.println();
		//通过对象调用
		a1.name="新新";
		a1.age=20;
		System.out.println("name:"+a1.name+"age:"+a1.age);

		System.out.println(a1.desc());
		
		
		
		
	}
	

}
class Animal{
	//1.属性
	String name;
	int age;
	
	//2.方法   提供某种功能的实现
	public void eat() {
		System.out.println("食物进食");
	}
	public void sleep() {
		System.out.println("动物休眠");
	}
	
	public String getName() {
		return name;
	}
	public void setName(String n) {
		name=n;
	}
	
	
	public void setAge(int n) {
		 age=n;
	}

	public int getAge() {
		System.out.println("hello");
		return age;
	}


	public String desc() {
		
		if(age>2) {
			return "少年";
		}else {
			return "还小";
		}
	}
	
	
}