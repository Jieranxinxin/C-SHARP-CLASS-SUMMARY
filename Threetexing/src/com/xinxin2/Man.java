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
		System.out.println("nanÈËË¯¾õ");
	}
	public void eat() {
		System.out.println("nanÈË³Ô·¹");
	}
	public void entertainment() {
		System.out.println("man Çë¿Í");
	}

}
