package test_com.xinxin.aixuei;

import org.junit.Test;

public class TestAll {

	@Test
	public void TestString() {
		// 一、字符串
		System.out.println("MWQ" + 1233);// 与int型连接
		System.out.println("10" + 4.5F);// 与float型连接
		// System.out.println("This is "+True);//与boolean型连接
		System.out.println("MR" + "YHH");
		// "\"换成“/”
		System.out.println("路径：" + (new java.io.File("D:/Learning/TestFile/3.txt")));

	}
	
	@Test
	public void TestBuffer() {
		StringBuffer sb1=new StringBuffer();
		//sb1.append("asdf");
	
		System.out.println(sb1.append("asdf1234"));
		System.out.println(sb1.delete(2, sb1.length())); 
		
	}
	

}
