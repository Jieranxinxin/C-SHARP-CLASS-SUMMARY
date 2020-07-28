package com20200423;

public class MyException extends RuntimeException{//一个类要变成异常类得继承Throwable体系下的类

	private String content;//异常描述信息
	
	public MyException(String content) { //构造方法
		this.content=content;
	}
	public String getMessage() { //获取描述信息
		return content;
	}
}
