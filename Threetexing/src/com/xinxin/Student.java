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
		System.out.println("吃饭");
	}
	public void sleep() {
		System.out.println("睡觉");
	}
	*/
    
    public void info() {
    	eat();
    	//System.out.println("name:"+name);
    	System.out.println("我是一个学生");
    }


}
