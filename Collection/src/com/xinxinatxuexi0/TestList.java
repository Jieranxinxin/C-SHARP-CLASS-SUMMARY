package com.xinxinatxuexi0;

import java.util.ArrayList;
import java.util.List;

import org.junit.Test;

public class TestList {
	
	//ArrarList ,List����Ҫʵ���ࣨList��̬���飩
	//ListList  ����ʵ��     �ص㣺����Ƶ���Ĳ����ɾ������
	//Vector(���ϵ�ʵ���࣬�̰߳�ȫ��)
	//����ʵ��
	/*
	 * List���÷���������add(Object obj)�� ɾ��remove�� �ģ�set(int index,Object obj)��
	 * 			  �飨get(int index)�� �壨add(int index ,Object obj)��  ���ȣ�size()��
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
		//7.�����״Ρ����һ�γ��ֵ�λ�ã�û�з���-1
		System.out.println("AA�״γ���λ�ã�"+list.indexOf("AA"));
		System.out.println("AA������λ�ã�"+list.lastIndexOf("AA"));
		//˵�������⣬��ȣ��򲻴���
		System.out.println(list.indexOf("AD")==list.lastIndexOf("AD"));
		System.out.println(list.indexOf(99));
		//8.���ش�fromindex��toindex��������List
		List list2=list.subList(0, 3);//����ҿ�
		System.out.println(list2);	
	}

	
	@Test
	public void testList1() {
		List list =new ArrayList();
		List list1=new ArrayList();
		//1.���   ���н�����������˳������
		list.add(123);
		list.add(456);
		list.add(new String("AA"));
		list.add(new String("BB"));
		list1.add("AASS");
		list1.add("HU");
		System.out.println(list);//���н�����������˳������
		//2.��ָ��λ�����
		list.add(0,555);
		System.out.println(list);
		//3.��ȡָ��λ�õ�Ԫ��
		Object obj=list.get(3);
		System.out.println(obj);
		System.out.println("δ����ǰlist1:"+list1);
		//4.��ָ������λ�ü�����Ԫ��   boolean list1.addAll(1,list)
		System.out.println("�Ƿ���ӳɹ���"+list1.addAll(1,list));
		System.out.println("���Ӻ�list1:"+list1);
		//5.ɾ��ָ������λ��Ԫ��
		System.out.println("ɾ��ǰ0λ��Ԫ�أ�"+list.get(0));
		list.remove(0);
		System.out.println("ɾ����0λ��Ԫ�أ�"+list.get(0));
		//6.����ָ��λ������Ԫ��Ϊ��
		list.set(1, "����");
		System.out.println(list);
	}

}
