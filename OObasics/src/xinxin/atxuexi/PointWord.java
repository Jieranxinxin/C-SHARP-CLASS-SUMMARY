package xinxin.atxuexi;
/*
 * this:
 * 1.���������������ԡ�������������
 * 2.this���Ϊ��ǰ���󡢵�ǰ���ڴ����Ķ���(˭���ң�˭���ǵ�ǰ����
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
	
	//������
	//�ղ�
	public Person(){
		
	}
	//����
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
		System.out.println("�Է�");
	}
	public void sleep() {
		System.out.println("˯��");
	}
	public void info() {
		System.out.println("name:"+name+"age:"+age);
	}
}