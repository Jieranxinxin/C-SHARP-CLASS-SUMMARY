package com.xinxin.aixuexin0;
/*
 * ����Զ���һ���쳣��
 * 1.�Զ�����쳣��Ҫ�̳����е��쳣��
 * 2.�ṩһ�����кţ��ṩ�������صĹ�����
 */

//Ҫ�뱣֤�Դ��쳣���Ǳ���Ҫ���ܵ��쳣�£�����Ҫ�̳�
public class MyException extends RuntimeException{//����ʱ�쳣
	//ȫ�ֳ���  ���кţ�����Ψһȷ���쳣��Ķ���
	static final long serialVersionUID = -703480745766939L;
	
	public MyException(){
		
	}
	public MyException(String msg){
		super(msg);
	}
	

}
