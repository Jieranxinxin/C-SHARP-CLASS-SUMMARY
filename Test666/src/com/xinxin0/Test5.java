package com.xinxin0;

import java.util.Scanner;

public class Test5 {
	public static void main(String[] args) {
		Vehicle v=new Vehicle();
		v.speed=1;
		v.type="荣威";
		System.out.println("车名："+v.type+"\n"+"此时它的速度为："+v.speed);
		v.move();
		Scanner in=new Scanner(System.in);
		System.out.println("请输入您希望增加的速度：");
		double a=in.nextInt();
		v.speedUp(a);
		System.out.println("请输入您希望减少的速度：");
		double b=in.nextInt();
		v.speedDown(b);
	}
}

class Vehicle {
	double speed;
	String type;

	public void move() {
		System.out.println("汽车开始启动");
		System.out.println("*********");

	}

	public void speedUp(double s) {// 加速
		//System.out.println("汽车开始加速,每次加1");
		this.speed =speed+s;
		System.out.println("此时加速后为：" + speed);
	}

	public void speedDown(double s) {// 减速
		
		this.speed = speed-s;
		if(speed<0) {
			System.out.println("减速后，速度小于0，请重新选择");
		}
		else {
		System.out.println("此时减速度为：" + speed);
		}
	}

}