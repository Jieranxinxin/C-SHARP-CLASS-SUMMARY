package com.xinxin;

import java.awt.HeadlessException;

import javax.swing.JFrame;
//1.�̳�JFrame������������Ӧ�İ�
public class FirstWindow extends JFrame{

	//3.�ڹ��췽���У����ó�ʼ������
	public FirstWindow() {
		init();
	}

	//2.����һ����������ʼ�����������
	public void init() {
		setTitle("����JFrame�ഴ������");
		setSize(800,500);
		setLocation(600,200);
		//�رշ�ʽ
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setVisible(true);
	}
}
//4.�����´���һ���࣬��main()�н���ʵ����
class WindowRun{
	public static void main(String[] args) {
		FirstWindow first=new FirstWindow();
	}
}
