package com.xinxin.aixuexi0;

public class Student {
	private String stuId;
	private String stuName;
	private String stuSex;
	private String stuPhoneNum;
	private String stuClass;
	
	public Student() {}
	public Student(String stuId,String stuName,String stuSex,String stuPhoneNum,String stuClass) {
		this.stuId=stuId;
		this.stuName=stuName;
		this.stuPhoneNum=stuPhoneNum;
		this.stuSex=stuSex;
		this.stuClass=stuClass;
		
	}
	public String getStuId() {
		return stuId;
	}
	public void setStuId(String stuId) {
		this.stuId = stuId;
	}
	public String getStuName() {
		return stuName;
	}
	public void setStuName(String stuName) {
		this.stuName = stuName;
	}
	public String getStuSex() {
		return stuSex;
	}
	public void setStuSex(String stuSex) {
		this.stuSex = stuSex;
	}
	public String getStuPhoneNum() {
		return stuPhoneNum;
	}
	public void setStuPhoneNum(String stuPhoneNum) {
		this.stuPhoneNum = stuPhoneNum;
	}
	public String getStuClass() {
		return stuClass;
	}
	public void setStuClass(String stuClass) {
		this.stuClass = stuClass;
	}
	public String toString() {
		return this.stuId+"\t"+this.stuName+"\t"+this.stuSex+"\t"+this.stuPhoneNum+"\t"+this.stuClass;
	}

}