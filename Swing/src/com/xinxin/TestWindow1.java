package com.xinxin;

import java.awt.HeadlessException;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;

public class TestWindow1 extends JFrame {
	private JTextField txtUser;//�ı���
	private JPasswordField txtPwd;//�����
	private JLabel IdUser,IdPwd;//��ǩ
	private JButton bOK,bExit;
	
	public static void main(String[] args) {
		TestWindow1 TW1=new TestWindow1();
	}
	
	public TestWindow1() {
		init();
	}

	public void init() {
		IdUser=new JLabel("�û�����");
		IdPwd=new JLabel("���룺");
		IdUser.setBounds(200, 100, 150, 30);//��x,y,������
		IdPwd.setBounds(200, 150, 150, 30);
		setLayout(null);//���ֹ���
		txtUser=new JTextField(10);//new һ��10���ַ�
		txtPwd=new JPasswordField(10);
		txtUser.setBounds(290,100, 120, 30);//�����ؼ�λ��
		txtPwd.setBounds(290,150, 120, 30);
		bOK=new JButton("ȷ��");
		bExit=new JButton("ȡ��");
		bOK.setBounds(210, 220, 65, 35);
		bExit.setBounds(340, 220, 65, 35);
		add(IdUser);//�ѿؼ���ӵ�����
		add(IdPwd);
		add(txtUser);
		add(txtPwd);
		add(bOK);
		add(bExit);
		setBounds(600,300,600,450);
		setTitle("��¼����");
		setVisible(true);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

}
