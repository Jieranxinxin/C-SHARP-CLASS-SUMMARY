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
	private double radius; //�뾶

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		this.radius = radius;
	}
	
	public  Circle2(double radius)  { //���췽��
		this.radius=radius;
	}
	public int compareTo(Object obj){  //�ȽϷ���
		if (this == obj) {   
			return 0;
		} else if (obj instanceof Circle2) {    //�жϴ���Ĳ����ǲ���Բ

			Circle2 cc = (Circle2) obj;
			if (this.radius > cc.radius) {
				return 1;
			} else if (this.radius == cc.radius) {
				return 0;
			} else {
				return -1;
			}
		}else {
			//�ֶ��׳��쳣  //���׳�����Error����RunTimeException,������ʹ��throws�ؼ���
			//throw new RuntimeException("���Ͳ�ƥ��");
			throw new MyException("���Ͳ�ƥ��");
		}
		
	}
}
