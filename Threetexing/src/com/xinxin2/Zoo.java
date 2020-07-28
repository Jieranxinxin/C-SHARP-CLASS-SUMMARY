package com.xinxin2;

public class Zoo {

	public void free(Animal animal){
		animal.move();
		System.out.println("我们要爱护动物，将其放生");
	}
	public static void main(String[] args) {
		Zoo zoo=new Zoo();
		Animal parrot=new Parrot();
		Animal rortoise=new Tortoise();
		zoo.free(parrot);
		zoo.free(rortoise);
	}
}
