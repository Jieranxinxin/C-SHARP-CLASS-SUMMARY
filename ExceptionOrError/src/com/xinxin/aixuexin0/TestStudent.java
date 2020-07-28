package com.xinxin.aixuexin0;

public class TestStudent {
public static void main(String[] args) {
	Student s=new Student();
	s.regist(-12);
	System.out.println(s);
}
}
class Student{
	int id;
	
	public void regist(int id) {
		if(id>0) {
			this.id=id;
			System.out.println(id);
		}else {
			throw new MyException(" ‰»Î”–ŒÛ");
		}
	}
}