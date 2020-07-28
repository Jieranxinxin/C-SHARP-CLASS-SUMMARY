package com.xinxinatxuexi;
//使用Runnable接口的方式，售票
//适合共享数据的问题
class Window1 implements Runnable{
	
	int ticket=50;

	public void run() {
		while(true) {
			if(ticket>0) {
				System.out.println(Thread.currentThread().getName()+"售票。票号为："+ticket--);
			}else {
				break;
			}
		}
	}
}

public class TestWindow1 {
	public static void main(String[] args) {
	Window1 w=new Window1();
	//共享同一个对象
	Thread t1=new Thread(w);
	Thread t2=new Thread(w);
	
	t1.setName("窗口一：");
	t2.setName("窗口二：");
	
	t2.start();
}
}
