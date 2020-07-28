package com20200423;

public class TestCircle {
public static void main(String[] args) {
		
		Circle2 c1=new Circle2(2.1);
		//Circle c2=new Circle(1);
		try {
		System.out.println(c1.compareTo(new String()));
		}catch(Exception e) {
			System.out.println(e.getMessage());
		}
		
	} 

}
 class Circle2 {
	private double radius; //半径

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		this.radius = radius;
	}
	
	public  Circle2(double radius)  { //构造方法
		this.radius=radius;
	}
	public int compareTo(Object obj){  //比较方法
		if (this == obj) {   
			return 0;
		} else if (obj instanceof Circle2) {    //判断传入的参数是不是圆

			Circle2 cc = (Circle2) obj;
			if (this.radius > cc.radius) {
				return 1;
			} else if (this.radius == cc.radius) {
				return 0;
			} else {
				return -1;
			}
		}else {
			//手动抛出异常  //若抛出的是Error或者RunTimeException,则无需使用throws关键字
			//throw new RuntimeException("类型不匹配");
			throw new MyException("类型不匹配");
		}
		
	}
}
