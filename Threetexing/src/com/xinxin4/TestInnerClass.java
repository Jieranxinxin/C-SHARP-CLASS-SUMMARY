package com.xinxin4;
/*
 * ��ĵ������Ա���ڲ���
 * 1.�൱��˵�����ǿ���������ڲ��ڶ����࣬
 * 2.�ڲ���ķ���    ��Ա�ڲ���(���������ڲ�������)and�ֲ��ڲ���
 * 3��Ա�ڲ���
 *   3.1���ⲿ���һ����Ա
 *   1>���������η���4����
 *   2>static final
 *   3>���Ե����ⲿ������Է���
 *   
 *   3.2��������ص�
 *   1>abstract
 *   2>�����������ڲ��������ԡ�������������
 * 4.�ֲ��ڲ���
 * 
 * 5.�����ڲ��࣬������Ҫ������������
 * ����δ�����Ա�ڲ���Ķ����磺����Bird���Dog��Ķ���
 * �������������ⲿ�ࡢ�ڲ���ı������ر��Ǳ�������ʱ��
 * �۾ֲ��ڲ����ʹ��
 * 
 */
public class TestInnerClass {
public static void main(String[] args) {
	//��ΪDog�Ǿ�̬�ģ����Կ���ֱ��ͨ��Person��Dog�Ĺ�����
	//������̬�ڲ���Ķ��󣬿���ֱ��ͨ���ⲿ����þ�̬�ڲ���Ĺ�����
	Person.Dog d=new Person.Dog();
	//ӦΪBird�ǷǾ�̬�ģ�So����ͨ���ⲿ�����
	//Person.Bird b=new Person.Bird();
	
	//�����Ǿ�̬���ڲ���Ķ��󣬱����ȴ����ⲿ��Ķ���ͨ���ⲿ��
	//�����ڲ���Ĺ�����
	Person p1=new Person();
	Person.Bird b=p1.new Bird();
	b.setName("a3");
	
}
}
class Person{
	String name="a1";
	int age;
	
	//��Ա�ڲ��ࣨ�Ǿ�̬��static��
	class Bird
	{
		String name="a2";
		int id;
		
		public Bird() {
			
		}
		public void setName(String name) {
			System.out.println(name);//a3
			//this ָ��setName�������Ǹ�
			System.out.println(this.name);//a2
			System.out.println(Person.this.name);//a1
		}
		public void info() {
			show();
		}
	 }
	
	
	public void show(){
		
		}
	public void method1() {
		//�������еĽоֲ��ڲ���
		class A{
			
		}
	}
	
	//��Ա�ڲ���  ����̬�ڲ��ࣩ
	static class Dog{
		
	}
}