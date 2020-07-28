package com.xinxin.aixuexin0;
/*
 * 如何自定义一个异常类
 * 1.自定义的异常类要继承现有的异常类
 * 2.提供一个序列号，提供几个重载的构造器
 */

//要想保证自创异常，那必须要在总的异常下，所以要继承
public class MyException extends RuntimeException{//运行时异常
	//全局常量  序列号：可以唯一确定异常类的对象
	static final long serialVersionUID = -703480745766939L;
	
	public MyException(){
		
	}
	public MyException(String msg){
		super(msg);
	}
	

}
