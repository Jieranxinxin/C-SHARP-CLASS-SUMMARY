package com.xinxin3;

/*
 * abstract:����ģ���������������ͷ���
 * 
 * 1.abstract�����࣬������
 * 1)���ɱ�ʵ����
 * 2���й�����  (�����඼�й���������Ϊ���㸸���ǳ����಻��ʵ������
 * �����������ʵ����)
 * 3�����󷽷����ڵ���һ���ǳ�����
 * 4���������п����г��󷽷�
 * 
 * 2.���η��������󷽷�
 * 1)��ʽ��û�з����壬����{}����public abstract void eat();
 * 2)���󷽷�ֻ���������Ĺ��ܣ��������ִ�У������̳г�����ĳ�������
 * ��������д���󷽷�
 * 3)������̳г����࣬����д�����еĳ��󷽷����������һ����ʵ���ࡱ���ȿ���ʵ����
 * 4��������̳г����࣬û����д���еĳ��󷽷�����ζ�Ŵ���������һ�����󷽷�
 * ������������Ϊ����ģ�
 */
public class TestAbstract {
	public static void main(String[] args) {
		// Person p1=new Person();
		// p1.eat();
		Student s1 = new Student();
		s1.eat();
		Person p1 = new Student();// ��̬
		p1.eat();
		//��̬�����ܵ㸸����û�еķ���

	}
}

abstract class Creator {
	abstract void breath();
}

abstract class Person extends Creator {
	String name;

	// ֻ�������ܣ�û�о����ʵ�֣�ʵ�ֽ������������
	public abstract void eat();

	public abstract void walk();

	// �������е�ʵ�巽��
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public Person() {

	}

	public Person(String name) {
		this.name = name;
	}
	public int Attitude(){
		return 0;
	}
}

class Student extends Person {
	public void eat() {
		System.out.println("ѧ���Է�");
	}

	public void walk() {
		System.out.println("ѧ����·");
	}

	@Override
	void breath() {
		System.out.println("ѧ����Ӧ�ú��������ʵĿ���");
	}
	public int S_Attitude(){
		return 0;
	}
	
}

abstract class Worker extends Person {
	public void eat() {
		System.out.println("���˳Է�");
	}
	// public void walk() {
	// System.out.println("������·");
	// }

}
