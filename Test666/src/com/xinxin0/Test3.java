package com.xinxin0;

public class Test3 {
	public  void sell(Car1 car1) {
		//car1.
		System.out.println("���ָ�����" + car1.wheel + "\n" + "�ܳ����ͺţ�" + car1.getName() + "\n" + "���ܳ�����ɫ��" + car1.getColor()
				+ "\n" + "���ܳ��ļ۸�" + car1.getPrice() + "��Ԫ");
	}

	public static void main(String[] args) {
		Test3 t = new Test3();
		t.sell(new Ferrari());
		t.sell(new Hypersport());

	}
}

interface Car1 {
	public final int wheel = 4;// �������ԣ������ĸ�

	String getName();// ��ȡ���ͺ�

	String getColor();// ��ȡ������ɫ

	double getPrice();// ��ȡ���ļ۸�
}

class Ferrari implements Car1 {

	@Override
	public String getName() {
		return "��������쳶�";
	}

	@Override
	public String getColor() {
		// TODO �Զ����ɵķ������
		return "red";
	}

	@Override
	public double getPrice() {
		// TODO �Զ����ɵķ������
		return 2250;
	}

}

class Hypersport implements Car1 {

	@Override
	public String getName() {
		// TODO �Զ����ɵķ������
		return "����";
	}

	@Override
	public String getColor() {
		// TODO �Զ����ɵķ������
		return "black";
	}

	@Override
	public double getPrice() {
		// TODO �Զ����ɵķ������
		return 9000;
	}

}