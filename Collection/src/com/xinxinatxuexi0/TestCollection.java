package com.xinxinatxuexi0;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.Date;
import java.util.Iterator;

import org.junit.jupiter.api.Test;

/*      因为没有使用泛型，所以出现！
 * Java集合
 * 	Collection接口
 * 		|----Set:元素无序、不可重复的集合---“高中集合”
 * 			|----HashSet（主要实现类）、LinkedHashSet、TreeSet
 * 		|----List:元素有序，可重复的集合---“动态数组”
 * 			|----ArrayList（主要的实现类）、LinkedList、Vector
 *  Map接口：具有映射关系“Key-value对”的集合  键不允许重复，值是可以重复的
 *  	|----HashMap、LinkedHashMap、TreeMap、Hashtable(子类，Properties)
 * 1.存储对象可以考虑：①数组 ②集合
 * 2.数组存储对象的特点：Student【】 stu=new Student【20】；stu[0]=new Student();
 * 	>弊端：①一旦创建，其长度不可变 ②真实的数组存放对象个数不可知
 * 3.
 */
public class TestCollection {
	
	@Test
	public void testtest() {
		Collection coll=new ArrayList();
		coll.add("AABB");
		boolean aa=coll.contains("AABB");
		System.out.println(aa);
		boolean bb=coll.contains("AABC") ;
		System.out.println(bb);
	}
	
	@Test
	public void testCollection3() {
		Collection coll=new ArrayList();
		coll.add(123);
		coll.add("AA");
		coll.add(new Date());
		coll.add("BB");
		
		Collection coll1=new ArrayList();
		coll1.add(123);
		coll1.add(new String("AA"));
		
		//10.coll.removeAll(coll1);从当前集合中删除包含在coll中的元素
		//是从该集合中移除同时包含在指定集合中的元素，    相当于去掉相同的部分
		coll.removeAll(coll1);
		System.out.println(coll);
		
		//11.coll1.equals(coll2) 判断两个集合中元素是否相同
		Collection coll2=new ArrayList();
		coll2.add(123);
		coll2.add(new String("AA"));
		System.out.println(coll1.equals(coll2));
		
		//12.hashCode()
		System.out.println(coll.hashCode());
		
		//13.toArray():将集合转化成数组
		Object[] obj= coll.toArray();
		System.out.println();
		for(int i=0;i<obj.length;i++) {
			System.out.println(obj[i]);
		}
		System.out.println();
		
		//14.iterator():返回一个Iterator接口，实现类的对象,进而实现集合的遍历
		Iterator iterator= coll.iterator();
		
		//方式一
//		System.out.println(iterator.next());
		//System.out.println(iterator.next());
		//System.out.println(iterator.next());
		//方式二
//		for(int i=0;i<coll.size();i++) {
//			System.out.println(iterator.next());
//		}
		//方式三  Java 迭代器最简单的实现
		while(iterator.hasNext()) {
			System.out.println(iterator.next());
		}
	}
	
	
	
	
	
	@Test
	public void testCollection2() {
		Collection coll=new ArrayList();
		coll.add(124);
		coll.add("AA");
		coll.add(new Date());
		
		//6.contains(Object obj):判断集合中是否包含指定的obj元素。如果包含，返回True
		boolean b1=coll.contains(124);
		System.out.println(b1);
		
		//7.containsAll(Collection coll):判断当前集合是否包含coll中所有的元素，返回布尔类型
		Collection coll1=new ArrayList();
		coll1.add(124);
		coll1.add(new String("AA"));
		boolean b2=coll.containsAll(coll1);
		System.out.println("#"+b2);
		
		//8.retainAll(Collection coll):求当前集合 与coll的共有元素，返回给当前集合，，交集
		coll.retainAll(coll1);
		System.out.println(coll);
		
		//9.remove(Object obj)   删除集合中的obj元素，若删除成功，返回true
		boolean b4=coll.remove("AA");
		System.out.println(b4);
		
	}
	
	
	@Test
	public void testCollection1() {
		Collection coll=new ArrayList();
		
		//1.size()返回集合（对象）中元素的个数
		System.out.println(coll.size());
		
		//2.add(Object obj)  可以存任何类型  向集合中添加一个元素
		coll.add(124);
		coll.add("AA");
		coll.add(new Date());
		System.out.println(coll.size());
		
		//3.addAll(Collection coll)  将形参coll中包含所有元素添加到当前集合中
		Collection coll1=Arrays.asList(1,2,3);
		coll.addAll(coll1);
		System.out.println(coll1.size());
		
		//4.isEmpty  返回布尔类型
		System.out.println(coll.isEmpty());
		//查看元素
		System.out.println(coll);
		
		//5.clear()清空集合元素
		coll.clear();
		System.out.println(coll.size());
		System.out.println(coll.isEmpty());
	}

}
