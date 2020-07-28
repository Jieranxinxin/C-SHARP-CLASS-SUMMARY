package com.xinxin4;

public class Test {
	public static void main(String[] args) {
		Tank T=new Tank();
		Flighter F=new Flighter();
		WarShip W=new WarShip();

		System.out.print("Tank的攻击方式是：");
		T.attack();
		System.out.print("Tank的移动方式是：");
	    T.move();
	    
	    System.out.print("Flighter的攻击方式是：");
		F.attack();
		System.out.print("Flighter的移动方式是：");
	    F.move();
		
	    System.out.print("WarShip的攻击方式是：");
		W.attack();
		System.out.print("WarShip的移动方式是：");
	    W.move();
	
		}
	
}

abstract class Weapon{
	public abstract void attack();
	public abstract void move();
}

class Tank extends Weapon{
	public void attack() {
		System.out.println("Tank攻击");
	}
	public void move() {
		System.out.println("Tank蹒跚移动");
	}
}
class Flighter extends Weapon{
	public void attack() {
		System.out.println("Flighter攻击");
	}
	public void move() {
		System.out.println("Flighter蹒跚移动");
	}
}
class WarShip extends Weapon{
	public void attack() {
		System.out.println("WarShip攻击");
	}
	public void move() {
		System.out.println("WarShip蹒跚移动");
	}
}