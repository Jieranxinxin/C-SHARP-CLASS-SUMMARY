package xinxin.atxuexi;

public class Zoo {
	public static void main(String[] args) {
		//���ʵ����
		Animal a1=new Animal();
		
		System.out.println("name:"+a1.name+"age:"+a1.age);
		
		System.out.println();
		//ͨ���������
		a1.name="����";
		a1.age=20;
		System.out.println("name:"+a1.name+"age:"+a1.age);

		System.out.println(a1.desc());
		
		
		
		
	}
	

}
class Animal{
	//1.����
	String name;
	int age;
	
	//2.����   �ṩĳ�ֹ��ܵ�ʵ��
	public void eat() {
		System.out.println("ʳ���ʳ");
	}
	public void sleep() {
		System.out.println("��������");
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
			return "����";
		}else {
			return "��С";
		}
	}
	
	
}