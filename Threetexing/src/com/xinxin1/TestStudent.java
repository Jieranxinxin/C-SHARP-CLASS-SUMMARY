package com.xinxin1;

public class TestStudent {
public static void main(String[] args) {
	Student s=new Student();
	s.show();
	
	System.out.println(s.getName()+":"+s.getAge());
	
	Student s1=new Student("我是学校");
	System.out.println(s1.getName()+":"+s1.getAge()+","+s1.schoolName);
	

}
}
