package com.xinxinatxuexi;
//ʹ��Runnable�ӿڵķ�ʽ����Ʊ
//�ʺϹ������ݵ�����
class Window1 implements Runnable{
	
	int ticket=50;

	public void run() {
		while(true) {
			if(ticket>0) {
				System.out.println(Thread.currentThread().getName()+"��Ʊ��Ʊ��Ϊ��"+ticket--);
			}else {
				break;
			}
		}
	}
}

public class TestWindow1 {
	public static void main(String[] args) {
	Window1 w=new Window1();
	//����ͬһ������
	Thread t1=new Thread(w);
	Thread t2=new Thread(w);
	
	t1.setName("����һ��");
	t2.setName("���ڶ���");
	
	t2.start();
}
}
