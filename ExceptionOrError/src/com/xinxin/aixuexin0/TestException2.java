package com.xinxin.aixuexin0;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

/*
 * �쳣����ķ�ʽ��
 * �ڷ���������������ʽ���׳����쳣�Ķ�������
 * ��ʽ����public static void method2() throws FileNotFoundException,IOException
 * ���˷����ڲ������쳣ʱ�����׳�һ���쳣��Ķ����׸������ĵ�����
 * �쳣�Ķ��������������ף�ֱ��main�У���Ȼ�������׵Ĺ����У�������ͨ��try-catch-finally���д���
 * 
 * java���쳣����ץ��ģ��
 * 1.ץ���쳣�������ַ�ʽ(��try-catch-finally��throws����һ���쳣������)
 * 2.�ף�һ��ִ�й����У������쳣�����׳��쳣����   ���֣��ֶ���throw+�쳣�Ķ��󣩣��Զ�
 *    >�쳣�࣬�ȿ������ֳɵ��쳣�࣬Ҳ�������Դ���
 * 
 * 
 * �������ۣ���������
 * throw   �쳣�����ɽ׶�   �ֶ��׳��쳣����
 * throws  �쳣�Ĵ���ʽ    ������������Ҫ�׳��ĸ����쳣��
 */
public class TestException2 {
	public static void main(String[] args){
		try {
			method2();
		} catch (IOException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		}
	
	}
	
	public static void method2() throws FileNotFoundException,IOException{
		method1();
	}
	
	
	
	//IOException�������FileNotFoundException  ��̬�Ĺ�ϵ
	//�Ѵ����׸������ĵ�����
	public static void method1() throws FileNotFoundException,IOException{
		//����һ���ļ�����Ӧ��ǰĿ¼֮��
		//���ܳ����ļ��Ҳ����쳣������ʱ�쳣
		//������������������׳�ȥthrows FileNotFoundException
		FileInputStream fis=new FileInputStream(new File("hello.txt"));
		int b;
		while((b=fis.read())!=-1) {
			//ת���ַ��ĸ�ʽ
			System.out.println((char)b);		
		}
		//����һ������Ҫ�ر�
		fis.close();
	}
}
