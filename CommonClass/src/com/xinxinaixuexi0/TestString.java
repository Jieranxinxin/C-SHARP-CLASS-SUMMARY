
package com.xinxinaixuexi0;

/*
 * 特点：
 * String是一个final类，代表不可变的字符序列 底层使用char[]存放
 * 
 */
import org.junit.jupiter.api.Test;

public class TestString {

	@Test
	public void test() {
		String a = "AAA";
		String b = new String("AAA");
		System.out.println(a.equals(b));// true

		String c = "ABCD";
		char x = c.charAt(0);
		System.out.println(x);// A
	}

	@Test
	public void test3() {
		String str1 = "山东xx协和山东";
		String str2 = "北京协和";

		// 从index位置开始,读取后面的
		String str3 = str1.substring(2);
		System.out.println(str3);// xx协和山东

		// 从startindex位置开始，到endindex（不包括）前一个位置结束
		String str4 = str1.substring(1, 4);// 左闭右开
		System.out.println(str4);// 东xx

		// 将所有的index都替换，串本身不改变
		String str5 = str1.replace("山东", "中国");
		System.out.println(str5);// 中国xx协和中国

		// 可以去掉 首尾 空格
		String str6 = "   a  bc d   ";
		String str7 = str6.trim();
		System.out.println(str7);

		// concat连接当前字符串
		String str8 = str1.concat(str2);
		System.out.println(str8);

		// split("x") 按照x进行拆分 整体返回String[]
		String[] str9 = str1.split("xx");

		for (int i = 0; i < str9.length; i++) {
			System.out.println(str9[i]);
		}

		// 全都变成小写
		String str11 = "AAxx";
		String str10 = str11.toLowerCase();
		System.out.println(str10);
		// toUpperCase()全都变成大写

		// equalsIgnoreCase 不区分大小写的比较内容
		String str12 = "AAXX";
		Boolean str13 = str12.equalsIgnoreCase(str11);
		System.out.println(str13);

	}

	@Test
	public void test2() {
		String str1 = "adbccdefgbcc";
		String str2 = "bcc";
		String str3 = "abdcdf33abgggab";
		String str4 = "ab";

		// 返回长度
		System.out.println(str1.length());
		// 返回指定index位置的字符,index从0开始
		System.out.println(str1.charAt(0));
		// 比较两个字符串是否相等，相等true
		System.out.println(str1.equals(str2));
		System.out.println(str2.equals("abcd"));

		// 主要排序时用 返回int型的值
		System.out.println(str1.compareTo(str2));// -1

		// 返回字符串在当前字符串中 首次 出现的位置 若无，返回-1
		System.out.println(str1.indexOf(str2));// 2

		// 最后 出现的位置
		System.out.println(str1.lastIndexOf(str2));// 9

		// 返回字符串从当前字符串startpoint位置开始，首次出现的位置
		System.out.println(str1.indexOf(str2, 5));// 9

		// 从第startpoint开始,看前边第一次出现的位置
		System.out.println(str3.lastIndexOf(str4, 5));

		// 判断其是否从index位置开始
		System.out.println(str1.startsWith("abc"));//false

		// 判断其是否从index位置结束
		System.out.println(str1.endsWith("cc"));//true

	}

	@Test
	public void test1() {
		// 先去字符串常量池里去找，没有就创建
		String str1 = "JavaEE";
		String str2 = "JavaEE";
		// 存到了字符数组里 有两个对象，一个value,一个str3
		String str3 = new String("JavaEE");
		String str4 = "JavaEE" + "Android";
		String str5 = "Android";
		String str6 = str1 + str5;
		str5 = str5 + "Handoop";
		String str7 = str4.intern();
		String str8 = "JavaEEAndroid";

		System.out.println(str1 == str2);// true
		System.out.println(str1 == str3);// false
		// System.out.println(type(str3));
		// equals判断比较内容
		System.out.println(str1.equals(str3));// true
		System.out.println(str4 == str8);// true

		System.out.println(str4 == str6);// false
		System.out.println(str4.equals(str6));// true
		System.out.println(str4 == str7);// true

		Person p1 = new Person("AA");
		Person p2 = new Person("AA");
		System.out.println("^-^  " + (p1.name == p2.name));

	}
}

class Person {
	String name;

	Person(String name) {
		this.name = name;
	}
}
