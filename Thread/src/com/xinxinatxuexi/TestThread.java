package com.xinxinatxuexi;

/*
 * ����һ�����̣߳����1-100֮����Ȼ���������ͬ�������߳�ִ��ͬ���Ĳ���
 * 
 * �������̵߳ĵ�һ�ַ�ʽ���̳�java.lang.Thread��
 *
 * ע�⣺
 * ��һ���߳�ֻ��ִ��һ��start
 * �ڲ���ͨ��Threadʵ�����run()����һ���߳�
 */
//1.����һ���̳���Thread������
class SubThread extends Thread {
	// 2.��дThread���run����������������ʵ�ִ����߳�Ҫ��ɵĹ���
	public void run() {
		for (int i = 1; i <= 100; i++) {
			// ��ȡ��ǰ���̵�����
			System.out.println(Thread.currentThread().getName() + ":" + i);
		}
	}
}

public class TestThread {
	public static void main(String[] args) {
		// 3.����һ������Ķ���
		SubThread st1 = new SubThread();
		SubThread st2 = new SubThread();

		// 4.�����̵߳�start(),�������̣߳�������Ӧ��run()
		st1.start();
		st2.start();
		
		//���߳�
		for (int i = 1; i <= 100; i++) {
			// ��ȡ��ǰ���̵�����
			System.out.println(Thread.currentThread().getName() + ":" + i);
		}
	}

}
