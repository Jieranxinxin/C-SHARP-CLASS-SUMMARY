package com.xinxinatxuexi;

/*
 * �������̵߳�ʵ�ַ�ʽ��
 * 
 * 
 * ���ַ�ʽ�Ա�   �̳�vsʵ��
 * 1.��ϵ   ��Ҫʵ��Runnable
 * 2.which best   why?
 *  ʵ�ָ���
 * 	�ٱ����˵��̳еľ�����
 * 	�ڶ���̲߳���ͬһ����Դ
 * 
 * 
 */

//1.����һ��ʵ����Runnable�ӿڵ���
class PrintNum implements Runnable{

	//2.ʵ�ֽӿڵĳ��󷽷�
	public void run() {
		for(int i=1;i<=40;i++) {
			System.out.println(Thread.currentThread().getName()+":"+ i);
		}
		
	}
	
}
public class TestThread2 {
	public static void main(String[] args) {
		//3������һ��Runnable�ӿ�ʵ����Ķ���
		PrintNum p=new PrintNum();
		//4.���˶�����Ϊ�βδ��ݸ�Thread��Ĺ������У�����thread���󣬴˶���Ϊһ���߳�
		Thread t1=new Thread(p);
		t1.setName("�߳�һ");
		//5.����start()�����̲߳�ִ��run()
		t1.start();//�����̣߳�ִ�е�Thread��������ʱ�������βεĶ����run()
		
		//Ҫ���������̣߳��������start()
		
		//�ڴ���һ���߳�
		Thread t2=new Thread(p);
		t2.setName("�̶߳�");
		t2.start();
	}

}
