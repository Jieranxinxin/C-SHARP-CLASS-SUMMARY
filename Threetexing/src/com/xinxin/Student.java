package com.xinxin;

public class Student extends Person{
	//private String name;
   // private int age;
    private String schoolName;
    
    public Student () {}
    public Student(String name,int age) {
    	//this.name=name;
    	//this.age=age;
    	this.setAge(age);
    	this.setName(name);
    }
    /*
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
    
	public void eat() {
		System.out.println("�Է�");
	}
	public void sleep() {
		System.out.println("˯��");
	}
	*/
    
    public void info() {
    	eat();
    	//System.out.println("name:"+name);
    	System.out.println("����һ��ѧ��");
    }


}
