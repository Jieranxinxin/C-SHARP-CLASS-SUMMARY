package com.xinxin0;

public class Test3 {
	public  void sell(Car1 car1) {
		//car1.
		System.out.println("车轮个数：" + car1.wheel + "\n" + "跑车的型号：" + car1.getName() + "\n" + "此跑车的颜色：" + car1.getColor()
				+ "\n" + "此跑车的价格：" + car1.getPrice() + "万元");
	}

	public static void main(String[] args) {
		Test3 t = new Test3();
		t.sell(new Ferrari());
		t.sell(new Hypersport());

	}
}

interface Car1 {
	public final int wheel = 4;// 汽车属性：车轮四个

	String getName();// 获取车型号

	String getColor();// 获取车的颜色

	double getPrice();// 获取车的价格
}

class Ferrari implements Car1 {

	@Override
	public String getName() {
		return "法拉利拉斐尔";
	}

	@Override
	public String getColor() {
		// TODO 自动生成的方法存根
		return "red";
	}

	@Override
	public double getPrice() {
		// TODO 自动生成的方法存根
		return 2250;
	}

}

class Hypersport implements Car1 {

	@Override
	public String getName() {
		// TODO 自动生成的方法存根
		return "狼崽";
	}

	@Override
	public String getColor() {
		// TODO 自动生成的方法存根
		return "black";
	}

	@Override
	public double getPrice() {
		// TODO 自动生成的方法存根
		return 9000;
	}

}