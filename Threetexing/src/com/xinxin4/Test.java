package com.xinxin4;

public class Test {
	public static void main(String[] args) {
		Tank T=new Tank();
		Flighter F=new Flighter();
		WarShip W=new WarShip();

		System.out.print("Tank�Ĺ�����ʽ�ǣ�");
		T.attack();
		System.out.print("Tank���ƶ���ʽ�ǣ�");
	    T.move();
	    
	    System.out.print("Flighter�Ĺ�����ʽ�ǣ�");
		F.attack();
		System.out.print("Flighter���ƶ���ʽ�ǣ�");
	    F.move();
		
	    System.out.print("WarShip�Ĺ�����ʽ�ǣ�");
		W.attack();
		System.out.print("WarShip���ƶ���ʽ�ǣ�");
	    W.move();
	
		}
	
}

abstract class Weapon{
	public abstract void attack();
	public abstract void move();
}

class Tank extends Weapon{
	public void attack() {
		System.out.println("Tank����");
	}
	public void move() {
		System.out.println("Tank�����ƶ�");
	}
}
class Flighter extends Weapon{
	public void attack() {
		System.out.println("Flighter����");
	}
	public void move() {
		System.out.println("Flighter�����ƶ�");
	}
}
class WarShip extends Weapon{
	public void attack() {
		System.out.println("WarShip����");
	}
	public void move() {
		System.out.println("WarShip�����ƶ�");
	}
}