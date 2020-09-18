package com.xinxin.aixuexin0;

import java.util.InputMismatchException;
import java.util.Scanner;

import org.junit.jupiter.api.Test;

public class TestException {
	//һ���쳣����ϵ�ṹ
	/*
	 * @Test��ʹ�� �÷������Բ���main�������þͿ��Բ��Գ����н������һ�ֲ��Է��� һ�㺯������Ҫ��main�������ò���ִ��
	 * ע�ⱻ���Եķ���������public���ε�
	 */
	/*
	 * java.lang.Throwable
	 * 		|-----Error:���󣬳����в����д���
	 * 		|-----Exception:�쳣��Ҫ���д����ʱ�迼�ǣ�����Щ�쳣�� ����
	 * 			|-----����ʱ�쳣   ִ��javac.exe�����쳣
	 * 			|-----����ʱ�쳣   ִ��java.exeʱ�����쳣
	 * ��ִ��һ������ʱ����������쳣���쳣��ĳ�����ִ��
	 */
	@Test
	public void test1() {
		Scanner s = new Scanner(System.in);
		// �Ӽ����Ͻ���һ��int�͵�ֵ
		try {
		int i = s.nextInt();
		System.out.println(i);
		}catch(InputMismatchException e){
			System.out.println("���Ͳ�ƥ��");
		}

	}
	
	/*
	 * ��������ʱ�쳣
	 * 1.�����±�Խ���쳣��ArrayIndexOutOfBoundsException
	 */
	@Test
	public void test2() {
		try {
		int[] i=new int[10];
		System.out.println(i[10]);
		System.out.println(i[-10]);
		}catch(Exception e) {
			System.out.println("�����쳣");
		}
	}
	/*
	 * 2.�����쳣
	 * 
	 */
	@Test
	public void test3() {
		try {
			int i=10;
			System.out.println(i/0);
		} catch (Exception e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		}
	}
	
	
}
