package com.xinxin2;

public class Man extends Person{
	private boolean smoking;
	public Man() {
		super();
	}
	public Man(boolean smoking) {
		super();
		this.smoking = smoking;
	}
	public boolean isSmoking() {
		return smoking;
	}
	public void setSmoking(boolean smoking) {
		this.smoking = smoking;
	}
	public void sleep() {
		System.out.println("nan��˯��");
	}
	public void eat() {
		System.out.println("nan�˳Է�");
	}
	public void entertainment() {
		System.out.println("man ���");
	}

}
