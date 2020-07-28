package com.xinxinatxuexi;

/*
 * 创建多线程的实现方式二
 * 
 * 
 * 两种方式对比   继承vs实现
 * 1.联系   都要实现Runnable
 * 2.which best   why?
 *  实现更好
 * 	①避免了单继承的局限性
 * 	②多个线程操作同一份资源
 * 
 * 
 */

//1.创建一个实现了Runnable接口的类
class PrintNum implements Runnable{

	//2.实现接口的抽象方法
	public void run() {
		for(int i=1;i<=40;i++) {
			System.out.println(Thread.currentThread().getName()+":"+ i);
		}
		
	}
	
}
public class TestThread2 {
	public static void main(String[] args) {
		//3。创建一个Runnable接口实现类的对象
		PrintNum p=new PrintNum();
		//4.将此对象作为形参传递给Thread类的构造器中，创建thread对象，此对象即为一个线程
		Thread t1=new Thread(p);
		t1.setName("线程一");
		//5.调用start()启用线程并执行run()
		t1.start();//启动线程，执行的Thread对象生成时构造器形参的对象的run()
		
		//要想启动多线程，必须调用start()
		
		//在创建一个线程
		Thread t2=new Thread(p);
		t2.setName("线程二");
		t2.start();
	}

}
