
package com.xinxinaixuexi0;

/*
 * �ص㣺
 * String��һ��final�࣬�����ɱ���ַ����� �ײ�ʹ��char[]���
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
		String str1 = "ɽ��xxЭ��ɽ��";
		String str2 = "����Э��";

		// ��indexλ�ÿ�ʼ,��ȡ�����
		String str3 = str1.substring(2);
		System.out.println(str3);// xxЭ��ɽ��

		// ��startindexλ�ÿ�ʼ����endindex����������ǰһ��λ�ý���
		String str4 = str1.substring(1, 4);// ����ҿ�
		System.out.println(str4);// ��xx

		// �����е�index���滻���������ı�
		String str5 = str1.replace("ɽ��", "�й�");
		System.out.println(str5);// �й�xxЭ���й�

		// ����ȥ�� ��β �ո�
		String str6 = "   a  bc d   ";
		String str7 = str6.trim();
		System.out.println(str7);

		// concat���ӵ�ǰ�ַ���
		String str8 = str1.concat(str2);
		System.out.println(str8);

		// split("x") ����x���в�� ���巵��String[]
		String[] str9 = str1.split("xx");

		for (int i = 0; i < str9.length; i++) {
			System.out.println(str9[i]);
		}

		// ȫ�����Сд
		String str11 = "AAxx";
		String str10 = str11.toLowerCase();
		System.out.println(str10);
		// toUpperCase()ȫ����ɴ�д

		// equalsIgnoreCase �����ִ�Сд�ıȽ�����
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

		// ���س���
		System.out.println(str1.length());
		// ����ָ��indexλ�õ��ַ�,index��0��ʼ
		System.out.println(str1.charAt(0));
		// �Ƚ������ַ����Ƿ���ȣ����true
		System.out.println(str1.equals(str2));
		System.out.println(str2.equals("abcd"));

		// ��Ҫ����ʱ�� ����int�͵�ֵ
		System.out.println(str1.compareTo(str2));// -1

		// �����ַ����ڵ�ǰ�ַ����� �״� ���ֵ�λ�� ���ޣ�����-1
		System.out.println(str1.indexOf(str2));// 2

		// ��� ���ֵ�λ��
		System.out.println(str1.lastIndexOf(str2));// 9

		// �����ַ����ӵ�ǰ�ַ���startpointλ�ÿ�ʼ���״γ��ֵ�λ��
		System.out.println(str1.indexOf(str2, 5));// 9

		// �ӵ�startpoint��ʼ,��ǰ�ߵ�һ�γ��ֵ�λ��
		System.out.println(str3.lastIndexOf(str4, 5));

		// �ж����Ƿ��indexλ�ÿ�ʼ
		System.out.println(str1.startsWith("abc"));//false

		// �ж����Ƿ��indexλ�ý���
		System.out.println(str1.endsWith("cc"));//true

	}

	@Test
	public void test1() {
		// ��ȥ�ַ�����������ȥ�ң�û�оʹ���
		String str1 = "JavaEE";
		String str2 = "JavaEE";
		// �浽���ַ������� ����������һ��value,һ��str3
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
		// equals�жϱȽ�����
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
