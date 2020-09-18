package com.xinxin.aixuexin0;
/*
 * 1.�ֶ����׳�һ���쳣������
 * 2.�׳����쳣���ͣ�����RuntimeException,���Բ���ʾ�Ĵ���
 * ����һ��Exception,����Ҫ��ʾ�Ĵ���
 * 
 */
public class TestCirlce {
	public static void main(String[] args) {
		Circle c1=new Circle(2.1);
		Circle c2=new Circle(2.1);
		System.out.println(c1.compareTo(c2));
		System.out.println(c1.compareTo(new String("AA")));
	}

}
class Circle{
	private double radius;
	
	public double getRadius() {
		return radius;
	}
	
	public void setRadius(double radius) {
		this.radius=radius;
	}
	
	//���ι�����
	public Circle(double radius) {
		super();
		this.radius=radius;
	}
	
	//�Ƚ�����Բ�뾶�Ĵ�С  
	//Object �� Java ����е�һ�������࣬Ҳ��������ĸ��ࡣ
	//��һ���౻��������û��ָ���̳еĸ��࣬��ôĬ�ϸ������ Object ��
	public int compareTo(Object obj) {
		if(this==obj) {
			return 0;
		}
		//instanceof �����������������ʱָ�������Ƿ����ض����һ��ʵ��
		//ͨ������һ������ֵ��ָ������������Ƿ�������ض�����������������һ��ʵ����
		else if(obj instanceof Circle) {
			//��objת����Բ
			Circle c=(Circle)obj;
			if(this.radius>c.radius) {
				return 1;
			}else if(this.radius==c.radius) {
				return 0;
			}else {
				return -1;
			}
		}else {
			//return -2;
			//�ֶ����׳��쳣
			throw new RuntimeException("�������������");
		}
	}
	
	
	
	
	
	
}