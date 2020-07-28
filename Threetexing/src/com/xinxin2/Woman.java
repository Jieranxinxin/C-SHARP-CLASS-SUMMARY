package com.xinxin2;

public class Woman extends Person{
	private boolean isBeauty;

	public Woman() {
		super();
	}

	public Woman(boolean isBeauty) {
		super();
		this.isBeauty = isBeauty;
	}

	public boolean isBeauty() {
		return isBeauty;
	}

	public void setBeauty(boolean isBeauty) {
		this.isBeauty = isBeauty;
	}
	public void sleep() {
		System.out.println("nvÈËË¯¾õ");
	}
	public void eat() {
		System.out.println("nvÈË³Ô·¹");
	}
	public void shoping() {
		System.out.println("nvÂòÂòÂò");
	}

	
}
