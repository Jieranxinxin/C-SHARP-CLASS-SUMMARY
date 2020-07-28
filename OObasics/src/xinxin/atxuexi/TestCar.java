package xinxin.atxuexi;

public class TestCar {
public static void main(String[] args) {
	Car c1=new Car();
	Car c2=new Car();
	
	c1.info();
	//属性，前提是你能调用
	c2.name="劳斯莱斯";
	c2.wheel=8;
	c2.info();
	
	
	//方法，前提是有方法，你有set方法，才可以c1.wheel=4;
	c1.name="玛莎拉蒂";
	c1.wheel=4;
	c1.info();
	
	
	Factory f=new Factory();
	Car c3=f.produceCar();
	f.describeCar(c3);
	
	Car c4=f.produceCar("太阳能汽车",2);
	f.describeCar(c4);
	
}
}

class Factory{
	//制造车
	//两个方法构成重载
	public Car produceCar() {
		return new Car();
	}
	
	public Car produceCar(String n,int w) {
		Car c=new Car();
		c.name=n;
		c.wheel=w;
		return c;
	}
	//描述车的信息，那个车的信息，通过形参来告诉
	public void describeCar(Car c) {
		c.info();
	}
}




class Car{
	//1.属性
	String name;
	int wheel;
	
	//2.方法
	public void info() {
		System.out.println("name: "+name+"\n"+"wheel: "+wheel);
	}
	
	public void show() {
		
		System.out.println("我是一辆车");
	}
	
	public String getName() {
		return name;
	}
	
	public void setName(String a) {
		name=a;
	}
	public void setWheel(int n) {
		wheel=n;
	}
	
}