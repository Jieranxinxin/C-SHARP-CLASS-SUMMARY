package com.xinxinatxuexi0;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.Date;
import java.util.Iterator;

import org.junit.jupiter.api.Test;

/*      ��Ϊû��ʹ�÷��ͣ����Գ��֣�
 * Java����
 * 	Collection�ӿ�
 * 		|----Set:Ԫ�����򡢲����ظ��ļ���---�����м��ϡ�
 * 			|----HashSet����Ҫʵ���ࣩ��LinkedHashSet��TreeSet
 * 		|----List:Ԫ�����򣬿��ظ��ļ���---����̬���顱
 * 			|----ArrayList����Ҫ��ʵ���ࣩ��LinkedList��Vector
 *  Map�ӿڣ�����ӳ���ϵ��Key-value�ԡ��ļ���  ���������ظ���ֵ�ǿ����ظ���
 *  	|----HashMap��LinkedHashMap��TreeMap��Hashtable(���࣬Properties)
 * 1.�洢������Կ��ǣ������� �ڼ���
 * 2.����洢������ص㣺Student���� stu=new Student��20����stu[0]=new Student();
 * 	>�׶ˣ���һ���������䳤�Ȳ��ɱ� ����ʵ�������Ŷ����������֪
 * 3.
 */
public class TestCollection {
	
	@Test
	public void testtest() {
		Collection coll=new ArrayList();
		coll.add("AABB");
		boolean aa=coll.contains("AABB");
		System.out.println(aa);
		boolean bb=coll.contains("AABC") ;
		System.out.println(bb);
	}
	
	@Test
	public void testCollection3() {
		Collection coll=new ArrayList();
		coll.add(123);
		coll.add("AA");
		coll.add(new Date());
		coll.add("BB");
		
		Collection coll1=new ArrayList();
		coll1.add(123);
		coll1.add(new String("AA"));
		
		//10.coll.removeAll(coll1);�ӵ�ǰ������ɾ��������coll�е�Ԫ��
		//�ǴӸü������Ƴ�ͬʱ������ָ�������е�Ԫ�أ�    �൱��ȥ����ͬ�Ĳ���
		coll.removeAll(coll1);
		System.out.println(coll);
		
		//11.coll1.equals(coll2) �ж�����������Ԫ���Ƿ���ͬ
		Collection coll2=new ArrayList();
		coll2.add(123);
		coll2.add(new String("AA"));
		System.out.println(coll1.equals(coll2));
		
		//12.hashCode()
		System.out.println(coll.hashCode());
		
		//13.toArray():������ת��������
		Object[] obj= coll.toArray();
		System.out.println();
		for(int i=0;i<obj.length;i++) {
			System.out.println(obj[i]);
		}
		System.out.println();
		
		//14.iterator():����һ��Iterator�ӿڣ�ʵ����Ķ���,����ʵ�ּ��ϵı���
		Iterator iterator= coll.iterator();
		
		//��ʽһ
//		System.out.println(iterator.next());
		//System.out.println(iterator.next());
		//System.out.println(iterator.next());
		//��ʽ��
//		for(int i=0;i<coll.size();i++) {
//			System.out.println(iterator.next());
//		}
		//��ʽ��  Java ��������򵥵�ʵ��
		while(iterator.hasNext()) {
			System.out.println(iterator.next());
		}
	}
	
	
	
	
	
	@Test
	public void testCollection2() {
		Collection coll=new ArrayList();
		coll.add(124);
		coll.add("AA");
		coll.add(new Date());
		
		//6.contains(Object obj):�жϼ������Ƿ����ָ����objԪ�ء��������������True
		boolean b1=coll.contains(124);
		System.out.println(b1);
		
		//7.containsAll(Collection coll):�жϵ�ǰ�����Ƿ����coll�����е�Ԫ�أ����ز�������
		Collection coll1=new ArrayList();
		coll1.add(124);
		coll1.add(new String("AA"));
		boolean b2=coll.containsAll(coll1);
		System.out.println("#"+b2);
		
		//8.retainAll(Collection coll):��ǰ���� ��coll�Ĺ���Ԫ�أ����ظ���ǰ���ϣ�������
		coll.retainAll(coll1);
		System.out.println(coll);
		
		//9.remove(Object obj)   ɾ�������е�objԪ�أ���ɾ���ɹ�������true
		boolean b4=coll.remove("AA");
		System.out.println(b4);
		
	}
	
	
	@Test
	public void testCollection1() {
		Collection coll=new ArrayList();
		
		//1.size()���ؼ��ϣ�������Ԫ�صĸ���
		System.out.println(coll.size());
		
		//2.add(Object obj)  ���Դ��κ�����  �򼯺������һ��Ԫ��
		coll.add(124);
		coll.add("AA");
		coll.add(new Date());
		System.out.println(coll.size());
		
		//3.addAll(Collection coll)  ���β�coll�а�������Ԫ����ӵ���ǰ������
		Collection coll1=Arrays.asList(1,2,3);
		coll.addAll(coll1);
		System.out.println(coll1.size());
		
		//4.isEmpty  ���ز�������
		System.out.println(coll.isEmpty());
		//�鿴Ԫ��
		System.out.println(coll);
		
		//5.clear()��ռ���Ԫ��
		coll.clear();
		System.out.println(coll.size());
		System.out.println(coll.isEmpty());
	}

}
