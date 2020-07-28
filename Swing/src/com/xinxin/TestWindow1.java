package com.xinxin;

import java.awt.HeadlessException;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;

public class TestWindow1 extends JFrame {
	private JTextField txtUser;//文本框
	private JPasswordField txtPwd;//密码框
	private JLabel IdUser,IdPwd;//标签
	private JButton bOK,bExit;
	
	public static void main(String[] args) {
		TestWindow1 TW1=new TestWindow1();
	}
	
	public TestWindow1() {
		init();
	}

	public void init() {
		IdUser=new JLabel("用户名：");
		IdPwd=new JLabel("密码：");
		IdUser.setBounds(200, 100, 150, 30);//（x,y,长，宽）
		IdPwd.setBounds(200, 150, 150, 30);
		setLayout(null);//布局管理
		txtUser=new JTextField(10);//new 一个10个字符
		txtPwd=new JPasswordField(10);
		txtUser.setBounds(290,100, 120, 30);//两个控件位置
		txtPwd.setBounds(290,150, 120, 30);
		bOK=new JButton("确定");
		bExit=new JButton("取消");
		bOK.setBounds(210, 220, 65, 35);
		bExit.setBounds(340, 220, 65, 35);
		add(IdUser);//把控件添加到窗体
		add(IdPwd);
		add(txtUser);
		add(txtPwd);
		add(bOK);
		add(bExit);
		setBounds(600,300,600,450);
		setTitle("登录窗体");
		setVisible(true);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

}
