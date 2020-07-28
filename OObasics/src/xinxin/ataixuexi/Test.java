package xinxin.ataixuexi;

public class Test {
	public static void main(String[] args) {
		Animal a1=new Animal();
		a1.name="鹌鹑";
		a1.setLegs(2);
		System.out.println("这个动物的名字是："+a1.name);
		System.out.println("它有"+a1.legs+"只腿");
		a1.info();
	}	
}

class Animal{
	String name;
	static int legs;

	public void setLegs(int l) {
		if(l>0&&l%2==0) {
			legs=l;
		}else {
			System.out.println("输入数据错误！");
		}
	}
	public int getLegs() {
		return legs;
	}
	
	public void info(){
		System.out.println("Animal [name=" + name + ", legs=" + legs + "]"); 
	}
	
}