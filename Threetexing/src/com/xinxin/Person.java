package com.xinxin;

public class Person {

	private String name;
    private int age;
    
    //public Person() {}
    
    
    
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
		System.out.println("³Ô·¹");
	}
	public void sleep() {
		System.out.println("Ë¯¾õ");
	}	    
		
}
