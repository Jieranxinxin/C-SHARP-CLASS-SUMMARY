package com.xinxinatxuexi;
/*
 * ģ���վ��Ʊ���ڣ�����2��������Ʊ������Ʊ50��
 * 
 */
class Window extends Thread{
	//�ѱ���������static,���乲��50��ȱ����������̫��
	static int ticked=50;
	public void run() {
		while(true) {
			if(ticked>0) {
				System.out.println(Thread.currentThread().getName()+"��Ʊ��Ʊ��Ϊ��"+ticked--);
			}else {
				break;
			}
		}
	}
}

public class TestWindow {
	public static void main(String[] args) {
		Window w1=new Window();
		Window w2=new Window();
		
		w1.setName("����һ��");
		w2.setName("���ڶ���");
		
		w1.start();
		w2.start();
	}
	
	

}
