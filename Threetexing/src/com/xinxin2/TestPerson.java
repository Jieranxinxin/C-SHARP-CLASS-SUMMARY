package com.xinxin2;
/*
 * ������������������̬��
 * 1.��̬��ָ����ʲô����̬�ԣ��������Ϊһ������Ķ��ֱ�����̬
 *   1�����������غ���д2���������Ķ�̬��
 * 2.�������Ķ�̬��ʹ�õ�ǰ�̣�1��Ҫ����ļ̳�2��Ҫ������Ը��෽������д
 * 3.�������з�Ϊ����״̬������״̬
 * ���ڶ�̬����˵������ʱ��������ߡ����������ñ������ɸ���Ķ���
 * ����ʱ�������ұߡ�����ע�����������ʵ�壬����Ķ�����ôִ�еķ�������������д��
 */
public class TestPerson {
public static void main(String[] args) {
	Person p=new Person();
	p.eat();
	p.sleep();
	
	Man m=new Man();
	m.eat();
	m.sleep();
	
	//�������Ķ�̬��,���������ָ���������
	Person p1=new Man();
	//���ⷽ�����ã�ͨ�����������ָ������Ķ���ʵ�壬�����÷���ʱ��
	//ʵ��ִ�е�ʱ������д����ķ���
	p1.eat();
	p1.sleep();
	
	Person p2=new Woman();//����ת��
	p2.eat();
	p2.sleep();
	//����ֻ�ܵ��������ж��еģ��ǵõ�������ת��
	Woman w=(Woman)p2;
	w.shoping();//ʹ��ǿ�Ʒ�
	/*
	 ����ֻ�ܱ��룬���г���
	Woman w1=(Woman)p1;
	w.shoping();
	ǿת���ԣ�����������֮���޹�ϵ�����оͻ����
	�������ҪС��
	*/
	//instanceof  ��ʽ  ����a instanceof ��A,�ж϶���a�Ƿ�����A��һ��ʵ��
	//�ǵĻ�������true,���򷵻�false
	//��a��A���ʵ������ôaҲһ����A�ุ���ʵ��
	if(p1 instanceof Woman) {
		Woman w1=(Woman)p1;
		w1.shoping();
	}
	if(p1 instanceof Man) {
		Man m1=(Man)p1;
		m1.entertainment();
	}
	if(p1 instanceof Person) {
		System.out.println("nihao");
	}
	
	
	
	
	
	
}
}



