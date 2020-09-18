package xinxin.atxuexi;

public class TestCar {
public static void main(String[] args) {
	Car c1=new Car();
	Car c2=new Car();
	
	c1.info();
	//���ԣ�ǰ�������ܵ���
	c2.name="��˹��˹";
	c2.wheel=8;
	c2.info();
	
	
	//������ǰ�����з���������set�������ſ���c1.wheel=4;
	c1.name="��ɯ����";
	c1.wheel=4;
	c1.info();
	
	
	Factory f=new Factory();
	Car c3=f.produceCar();
	f.describeCar(c3);
	
	Car c4=f.produceCar("̫��������",2);
	f.describeCar(c4);
	
}
}

class Factory{
	//���쳵
	//����������������
	public Car produceCar() {
		return new Car();
	}
	
	public Car produceCar(String n,int w) {
		Car c=new Car();
		c.name=n;
		c.wheel=w;
		return c;
	}
	//����������Ϣ���Ǹ�������Ϣ��ͨ���β�������
	public void describeCar(Car c) {
		c.info();
	}
}




class Car{
	//1.����
	String name;
	int wheel;
	
	//2.����
	public void info() {
		System.out.println("name: "+name+"\n"+"wheel: "+wheel);
	}
	
	public void show() {
		
		System.out.println("����һ����");
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