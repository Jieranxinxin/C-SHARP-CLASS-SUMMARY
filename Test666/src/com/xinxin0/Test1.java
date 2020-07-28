//package com.xinxin0;
//
//public class Test1 {
//	public static void main(String[] args) {
//		Person p = new Person();
//		Car c = new Car();
//		Bird b = new Bird();
//
//		p.start();
//		p.run();
//		p.stop();
//		p.dance();
//
//	}
//}
//
//interface Runner {
//	abstract void start();
//
//	abstract void run();
//
//	abstract void stop();
//}
//
//class Person implements Runner {
//
//	@Override
//	public void start() {
//		System.out.println("人要开始跑了");
//	}
//
//	@Override
//	public void run() {
//		System.out.println("人正在跑");
//	}
//
//	@Override
//	public void stop() {
//		System.out.println("人类跑步停止");
//	}
//
//	public void dance() {
//		System.out.println("人们在跳舞哟");
//	}
//
//}
//
//class Car implements Runner {
//
//	@Override
//	public void start() {
//		System.out.println("车以加好油门，准备开始");
//	}
//
//	@Override
//	public void run() {
//		System.out.println("汽车在柏路上奔驰");
//	}
//
//	@Override
//	public void stop() {
//		System.out.println("汽车停靠路边");
//	}
//
//	public void fillFuel() {
//		System.out.println("汽车正在加油站加油，请稍后");
//	}
//
//	public void crack() {
//		System.out.println("O　NO　车胎爆了");
//	}
//}
//
//class Bird implements Runner {
//
//	@Override
//	public void start() {
//		System.out.println("鸟儿振臂，欲高飞");
//	}
//
//	@Override
//	public void run() {
//		System.out.println("小鸟背着翅膀歪歪的跑");
//	}
//
//	@Override
//	public void stop() {
//		System.out.println("鸟儿落在枝桠休息");
//	}
//
//	public void fly() {
//		System.out.println("鸟儿在蓝天遨游");
//	}
//
//}
