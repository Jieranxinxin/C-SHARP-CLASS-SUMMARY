package com.xinxinatxuexi0;

import java.util.ArrayList;
import java.util.List;

import org.junit.Test;

public class TestList {
	
	//ArrarList ,List的主要实现类（List动态数组）
	//ListList  链表实现     特点：对于频繁的插入和删除操作
	//Vector(古老的实现类，线程安全的)
	//数组实现
	/*
	 * List常用方法：增（add(Object obj)） 删（remove） 改（set(int index,Object obj)）
	 * 			  查（get(int index)） 插（add(int index ,Object obj)）  长度（size()）
	 * 
	 */

	@Test
	public void testList2() {
		List list =new ArrayList();
		List list1=new ArrayList();
		list.add(123);
		list.add("AA");
		list.add(456);
		list.add(new String("AA"));
		list.add(new String("BB"));
		list1.add("AASS");
		list1.add("HU");
		System.out.println(list);
		//7.查找首次、最后一次出现的位置，没有返回-1
		System.out.println("AA首次出现位置："+list.indexOf("AA"));
		System.out.println("AA最后出现位置："+list.lastIndexOf("AA"));
		//说明的问题，相等，或不存在
		System.out.println(list.indexOf("AD")==list.lastIndexOf("AD"));
		System.out.println(list.indexOf(99));
		//8.返回从fromindex到toindex结束的子List
		List list2=list.subList(0, 3);//左闭右开
		System.out.println(list2);	
	}

	
	@Test
	public void testList1() {
		List list =new ArrayList();
		List list1=new ArrayList();
		//1.添加   运行结果，按照添加顺序来的
		list.add(123);
		list.add(456);
		list.add(new String("AA"));
		list.add(new String("BB"));
		list1.add("AASS");
		list1.add("HU");
		System.out.println(list);//运行结果，按照添加顺序来的
		//2.在指定位置添加
		list.add(0,555);
		System.out.println(list);
		//3.获取指定位置的元素
		Object obj=list.get(3);
		System.out.println(obj);
		System.out.println("未增加前list1:"+list1);
		//4.在指定索引位置加所有元素   boolean list1.addAll(1,list)
		System.out.println("是否添加成功："+list1.addAll(1,list));
		System.out.println("增加后list1:"+list1);
		//5.删除指定索引位置元素
		System.out.println("删除前0位置元素："+list.get(0));
		list.remove(0);
		System.out.println("删除后0位置元素："+list.get(0));
		//6.设置指定位置索引元素为：
		list.set(1, "新新");
		System.out.println(list);
	}

}
