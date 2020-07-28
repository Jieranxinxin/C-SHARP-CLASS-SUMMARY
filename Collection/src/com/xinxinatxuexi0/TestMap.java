package com.xinxinatxuexi0;

import java.util.HashMap;
import java.util.Map;

import org.junit.Test;

/*
 * Collection接口
 * 
 * Map接口
 * 		|---HashMap:(Map的主要的实现类)
 * 		|---LinkedHashMap:
 * 		|---Hashtable
 * 			|---Properties:
 * 
 * 
 */
public class TestMap {
	
	
	
	
	/*
	 * 1.HashMap : key是用set存放的，不可重复，跟函数差不多
	 *             value使用Collection存放的，可重复
	 *一个key对应一个value对，是一个Entry，所有的Entry是用Set存放的，也是不可重复的
	 * 2.向HashMap中添加元素时，会调用key所在类的equals()方法，判断两个key是否相同，
	 * 若相同只能添加进一个，且是后添加的那个将新添加的那个覆盖
	 */
	@Test
	public void test1() {
		Map map=new HashMap();
		//1.增加元素put
		map.put("AA", 123);
		map.put("BB", 456);
		map.put(123,"CC");
		map.put(null, null);
		map.put(new Person("DD",23), 50);
		map.put(new Person("DD",23), 54);
		//2.查看元素长度   (map.size())
		System.out.println(map.size());
		System.out.println(map);
		//3.按照指定的key删除此key-value
		map.remove("BB");
		System.out.println(map);
		//4.void clear() 清空
		//5.输入key获取指定位置的value  不存在返回null
		Object q=map.get("AA");
		System.out.println(q);
		//6.boolean containsKey(Object Key)
		//7.boolean containsValue(Object Value)
		
		
	}

}







