package com.xinxinaixuexi0;

import java.util.Date;

import org.junit.Test;

/*
 * ��ʱ����ص���
 * 1.System���µ�currentTimeMillis();
 * 2.Date�ࣺjava.util.Date�Լ�������java.sql.Date
 * java.util.Date  ��ʾ�ض���˲�䣬��ȷ����
 * 3.SimpleDateformat��
 * 4.Calendar��
 * 
 */
public class TestDate {
	@Test
	public void TestDate() {
		//����һ��Dateʵ��
		//util�µ�
		Date d1=new Date();
		System.out.println(d1.toString());//Thu Apr 30 11:33:17 CST 2020
		System.out.println(d1.getTime());//1588218000021
		
		Date d3=new Date(d1.getTime());
		System.out.println(d3);//Thu Apr 30 11:43:14 CST 2020
		
		java.sql.Date d2=new java.sql.Date(d1.getTime());//Long�Ͳ���
		System.out.println(d2);//2020-04-30
		
		
	}

}
