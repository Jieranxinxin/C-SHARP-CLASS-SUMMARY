package com.xinxinatxuexi;
/*
 * 模拟火车站售票窗口，开启2个窗口售票，总售票50张
 * 
 */
class Window extends Thread{
	//把变量声明成static,让其共用50，缺点生命周期太长
	static int ticked=50;
	public void run() {
		while(true) {
			if(ticked>0) {
				System.out.println(Thread.currentThread().getName()+"售票。票号为："+ticked--);
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
		
		w1.setName("窗口一：");
		w2.setName("窗口二：");
		
		w1.start();
		w2.start();
	}
	
	

}
