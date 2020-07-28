package com.xinxinaixuexi0;

import java.util.Date;

import org.junit.Test;

/*
 * 与时间相关的类
 * 1.System类下的currentTimeMillis();
 * 2.Date类：java.util.Date以及其子类java.sql.Date
 * java.util.Date  表示特定的瞬间，精确毫秒
 * 3.SimpleDateformat类
 * 4.Calendar类
 * 
 */
public class TestDate {
	@Test
	public void TestDate() {
		//创建一个Date实例
		//util下的
		Date d1=new Date();
		System.out.println(d1.toString());//Thu Apr 30 11:33:17 CST 2020
		System.out.println(d1.getTime());//1588218000021
		
		Date d3=new Date(d1.getTime());
		System.out.println(d3);//Thu Apr 30 11:43:14 CST 2020
		
		java.sql.Date d2=new java.sql.Date(d1.getTime());//Long型参数
		System.out.println(d2);//2020-04-30
		
		
	}

}
