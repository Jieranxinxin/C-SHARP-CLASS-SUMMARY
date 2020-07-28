package com.xinxin0;

public class Test6 {
	public static void main(String[] args) {
		String str1="AABBCC";
		String str2="bbCCDD";
//		System.out.println(str1.substring(2, 4).toLowerCase());
//		System.out.println(str2.substring(0,2).toLowerCase());

		if(str1.substring(2, 4).toLowerCase().equals(str2.substring(0,2).toLowerCase())) {
			System.out.println("两个子串相同");
		}else {
			System.out.println("两个子串不相同");
		}
	}
	

    

}
