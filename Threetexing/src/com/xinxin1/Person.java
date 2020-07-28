package com.xinxin1;

public class Person {
	private String name;
	protected int age=19;
    int id=1001;//人的身份证号
    
    public Person() {
    	System.out.println("这是person空参的构造器");
    	this.name="AA";
    	this.age=1;
    }
    public Person(String name) {
    	this();
    	this.name=name;
    }
    public Person(String name,int age) {
    	this(name);
    	this.age=age;
    }
    
    
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

}
