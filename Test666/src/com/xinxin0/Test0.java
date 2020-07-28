package com.xinxin0;

public class Test0 {
	public void sellCar(Car car) {
		System.out.println("您选择的车型是：" + car.getName() + ","
				+ "车的颜色是：" + car.getColor() + ",价格是：" + car.getPrice() + "万元");
	}

	public static void main(String[] args) {
		Test0 car = new Test0();
		car.sellCar(new BMW());
		car.sellCar(new Audi());
		
	}
}

interface Car {
	String getName();

	String getColor();

	double getPrice();
}

class BMW implements Car {
	public String getName() {
		return "宝马7系";
	}

	public String getColor() {
		return "雪柏白晶";
	}

	public double getPrice() {
		return 270.35;
	}

}

class Audi implements Car {
	public String getName() {
		return "Q7";
	}

	public String getColor() {
		return "魔力黑";
	}

	public double getPrice() {
		return 133.9;
	}

}