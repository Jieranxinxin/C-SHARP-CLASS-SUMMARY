package com.xinxinatxuexi0;

import java.util.HashSet;
import java.util.Set;
import java.util.TreeSet;

import org.junit.Test;
/*
 * Set�������û�������ģ����ǵ���Collection����� 
 */
public class TestSet {
	
	/*
	 * TreeSet:
	 * 1.��TreeSet�����Ԫ�ر���ʱͬһ���͵�
	 * 2.���԰�����ӽ������е�Ԫ�ص�ָ��˳�������
	 * ��String����װ���Ĭ�ϰ��մ�С����˳�����
	 * 
	 */
	@Test
	public void testTreeSet1() {
		Set set=new TreeSet();
//		set.add(123);
//		set.add(456);
//		set.add(new String("AA"));
//		set.add(new String("AA"));
//		set.add("BB");
//		set.add("CC");
		//��Person��û��ʵ��Comparable�ӿ�ʱ������TreeSet�����Person����ʱ����ClassCastException
		set.add(new Person("GG",23));
		set.add(new Person("MM",21));
		set.add(new Person("JJ",20));
		set.add(new Person("MG",29));
		set.add(new Person("OO",25));
		
		
		for(Object str:set) {
			System.out.println(str);
		}
	}
	
	
	
	
	
	/*
	 * Set:�洢��Ԫ��ʱ����ģ������ظ���
	 * 1.������    �����ԣ�=�����   �����������ԣ�ָ����Ԫ���ڵײ�洢��λ���������
	 * 2.�����ظ���     ����set֮�������ͬ��Ԫ��ʱ������ļӲ���ȥ
	 *   
	 *  3.˵����Ҫ����ӽ�Set�е�Ԫ�����ڵ��࣬һ��Ҫ��дequals()��hashCode()����
	 *  ������֤Set��Ԫ�صĲ����ظ���
	 *  
	 *  Set��Ԫ������δ洢��  ʹ���˹�ϣ�㷨
	 *  ����Set����Ӷ���ʱ�����ȵ��ô˶����������hashCode()����������˶���Ĺ�ϣֵ
	 *  �˹�ϣֵ�����˴˶�����Set�д洢λ�á�����λ��֮ǰû�д洢������˶���ֱ�Ӵ洢����λ��
	 *  ����λ��֮ǰ���д洢������ͨ��equals()�Ƚ������������Ƿ���ͬ��if��ͬ����һ�����󲻿����
	 *  
	 *  ��һ����false  ���洢�����ǲ�����
	 *  ��Ҫ��hashCode()����Ҫ��equals()����һ��
	 */
	
	
	
	@Test
	public void testHashSet() {
		Set set=new HashSet();
		set.add(123);
		set.add(456);
		set.add("AAA");
		set.add("BBB");
		set.add(null);
		Person p1=new Person("GG",23);
		Person p2=new Person("MM",21);
		Person p3=new Person("GG",23);
		set.add(p1);
		set.add(p2);
		set.add(p3);
		System.out.println(p1.hashCode());
		System.out.println(p2.hashCode());
		System.out.println(p3.hashCode());

		System.out.println(set.size());
		System.out.println(set);
	}

}
