package com.xinxin0;

/*
 * ���̳ж�ʵ��
 * �ӿڣ�interface�������ಢ�е�һ������
 * 1.�ӿڿ��Կ���һ������ĳ����࣬��    ����  ��  ���󷽷�  ��һ������.���ܰ���������һ�㷽��
 * 2.�ӿ��޹�����
 * 3.�ӿڶ���ľ���һ�ֹ��ܣ��˹��ܿ��Ա�����ʵ�֣�implements��.�磺class C implements A
 * 4.ʵ�ֽӿڵ��࣬����Ҫ��д���еĳ��󷽷�������ʵ��������û����д���еĳ��󷽷���������Ϊһ��������
 * 5.�����ʵ�ֶ���ӿ�
 * 
 * 6.�ӿ���ӿ�֮���Ǽ̳еĹ�ϵ  ���ҿ��Զ�̳�

 *
 */
public class TestInterface {
	public static void main(String[] args) {
		System.out.println(A.I);
		// sysout
	}
}

interface A {
	// 1.�ӿ��ﶼ�ǳ���
	// static ˵����һ��ȫ�ֵ� final ˵����һ������
	public static final int I = 4;
	// ��Ϊ���еĳ������� public static final ���Σ����Կ���ʡ�Բ�д
	boolean FLAG = false;

	// 2.���󷽷� �ӿڶ��ǳ��󷽷�
	// ������ʱ����public abstract ��SO��ʡ��
	public abstract void method1();

	void method2();

}

// ����д����abstract ���ǳ������
abstract class B implements A {

}

class D {

}

interface M {
	void method3();
}

// ��д���� �̳���ʵ�ֲ���
class C extends D implements A, M {
	public void method1() {

	}

	public void method2() {

	}

	public void method3() {

	}
}

// �ӿڽӿ�֮�����ʵ�ֶ�̳�
interface J extends M, A {
	void method4();
}

class G implements J {

	@Override
	public void method3() {
		// TODO �Զ����ɵķ������

	}

	@Override
	public void method4() {
		// TODO �Զ����ɵķ������

	}

	@Override
	public void method1() {
		// TODO �Զ����ɵķ������

	}

	@Override
	public void method2() {
		// TODO �Զ����ɵķ������

	}

}