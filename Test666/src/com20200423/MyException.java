package com20200423;

public class MyException extends RuntimeException{//һ����Ҫ����쳣��ü̳�Throwable��ϵ�µ���

	private String content;//�쳣������Ϣ
	
	public MyException(String content) { //���췽��
		this.content=content;
	}
	public String getMessage() { //��ȡ������Ϣ
		return content;
	}
}
