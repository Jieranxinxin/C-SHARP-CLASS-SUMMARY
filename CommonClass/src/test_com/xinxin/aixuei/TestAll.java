package test_com.xinxin.aixuei;

import org.junit.Test;

public class TestAll {

	@Test
	public void TestString() {
		// һ���ַ���
		System.out.println("MWQ" + 1233);// ��int������
		System.out.println("10" + 4.5F);// ��float������
		// System.out.println("This is "+True);//��boolean������
		System.out.println("MR" + "YHH");
		// "\"���ɡ�/��
		System.out.println("·����" + (new java.io.File("D:/Learning/TestFile/3.txt")));

	}
	
	@Test
	public void TestBuffer() {
		StringBuffer sb1=new StringBuffer();
		//sb1.append("asdf");
	
		System.out.println(sb1.append("asdf1234"));
		System.out.println(sb1.delete(2, sb1.length())); 
		
	}
	

}
