package com.xinxin0;

public class Test0 {
	public void sellCar(Car car) {
		System.out.println("��ѡ��ĳ����ǣ�" + car.getName() + ","
				+ "������ɫ�ǣ�" + car.getColor() + ",�۸��ǣ�" + car.getPrice() + "��Ԫ");
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
		return "����7ϵ";
	}

	public String getColor() {
		return "ѩ�ذ׾�";
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
		return "ħ����";
	}

	public double getPrice() {
		return 133.9;
	}

}