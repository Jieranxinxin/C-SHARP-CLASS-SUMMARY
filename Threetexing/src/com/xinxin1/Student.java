package com.xinxin1;
/*
 * super:�����������ԡ�������������
 * 1>
 * �������븸������ͬ������ʱ������ͨ����super.�����ԡ���ʾ�ĵ��ø����е���������
 * ������������ͬ�������ԡ�this.�����ԡ�
 * 2>
 * ��������д����ķ����Ժ�����������������ʾ�ĵ��ø���ı���д�ķ���������Ҫ����
 * ��super.������
 * 3>super���ι�����    ͨ����������ʹ�á�super(�β��б�������ʾ�ĵ��ø�����ָ���Ĺ�����
 *   >�ڹ������ڲ�����super(�β��б�)����������������
 *   >�ڹ������ڲ�����this���β��б�����super(�β��б�)��ֻ�ܳ���һ��
 *   >���������У�����ʾ�ĵ��á�this���β��б�����super(�β��б�)��
 *   ����һ����Ĭ�ϵ��ø���ղεĹ�����
 *   ���飺���һ����ʱ�������ṩһ���ղεĹ�����
 *   ��������object
 *   
 *   
 */
public class Student extends Person{
	protected String schoolName;
	int id=1002;//ѧ��

	public Student() {
		//super();
	}
	
	public Student(String schoolName) {
		super ("keke",20);
		
		this.schoolName=schoolName;
	}

	public void show() {
		System.out.println(this.id);//1002
		System.out.println(super.id);//1001
		System.out.println(this.schoolName);
	}
}
