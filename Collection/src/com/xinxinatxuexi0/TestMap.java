package com.xinxinatxuexi0;

import java.util.HashMap;
import java.util.Map;

import org.junit.Test;

/*
 * Collection�ӿ�
 * 
 * Map�ӿ�
 * 		|---HashMap:(Map����Ҫ��ʵ����)
 * 		|---LinkedHashMap:
 * 		|---Hashtable
 * 			|---Properties:
 * 
 * 
 */
public class TestMap {
	
	
	
	
	/*
	 * 1.HashMap : key����set��ŵģ������ظ������������
	 *             valueʹ��Collection��ŵģ����ظ�
	 *һ��key��Ӧһ��value�ԣ���һ��Entry�����е�Entry����Set��ŵģ�Ҳ�ǲ����ظ���
	 * 2.��HashMap�����Ԫ��ʱ�������key�������equals()�������ж�����key�Ƿ���ͬ��
	 * ����ֻͬ����ӽ�һ�������Ǻ���ӵ��Ǹ�������ӵ��Ǹ�����
	 */
	@Test
	public void test1() {
		Map map=new HashMap();
		//1.����Ԫ��put
		map.put("AA", 123);
		map.put("BB", 456);
		map.put(123,"CC");
		map.put(null, null);
		map.put(new Person("DD",23), 50);
		map.put(new Person("DD",23), 54);
		//2.�鿴Ԫ�س���   (map.size())
		System.out.println(map.size());
		System.out.println(map);
		//3.����ָ����keyɾ����key-value
		map.remove("BB");
		System.out.println(map);
		//4.void clear() ���
		//5.����key��ȡָ��λ�õ�value  �����ڷ���null
		Object q=map.get("AA");
		System.out.println(q);
		//6.boolean containsKey(Object Key)
		//7.boolean containsValue(Object Value)
		
		
	}

}







