package com.xinxin;

import java.awt.HeadlessException;

import javax.swing.JFrame;
//1.继承JFrame，进而引入相应的包
public class FirstWindow extends JFrame{

	//3.在构造方法中，调用初始化方法
	public FirstWindow() {
		init();
	}

	//2.定义一个方法，初始化窗体的属性
	public void init() {
		setTitle("利用JFrame类创建窗体");
		setSize(800,500);
		setLocation(600,200);
		//关闭方式
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setVisible(true);
	}
}
//4.再重新创建一个类，在main()中进行实例化
class WindowRun{
	public static void main(String[] args) {
		FirstWindow first=new FirstWindow();
	}
}
