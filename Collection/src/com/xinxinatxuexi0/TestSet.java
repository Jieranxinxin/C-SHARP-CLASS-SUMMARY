package com.xinxinatxuexi0;

import java.util.HashSet;
import java.util.Set;
import java.util.TreeSet;

import org.junit.Test;
/*
 * Set里基本上没有新增的，都是调用Collection里面的 
 */
public class TestSet {
	
	/*
	 * TreeSet:
	 * 1.向TreeSet中添加元素必须时同一类型的
	 * 2.可以按照添加进集合中的元素的指定顺序遍历。
	 * 像String，包装类等默认按照从小到大顺序遍历
	 * 
	 */
	@Test
	public void testTreeSet1() {
		Set set=new TreeSet();
//		set.add(123);
//		set.add(456);
//		set.add(new String("AA"));
//		set.add(new String("AA"));
//		set.add("BB");
//		set.add("CC");
		//当Person类没有实现Comparable接口时，当向TreeSet中添加Person对象时，报ClassCastException
		set.add(new Person("GG",23));
		set.add(new Person("MM",21));
		set.add(new Person("JJ",20));
		set.add(new Person("MG",29));
		set.add(new Person("OO",25));
		
		
		for(Object str:set) {
			System.out.println(str);
		}
	}
	
	
	
	
	
	/*
	 * Set:存储的元素时无序的，不可重复的
	 * 1.无序性    无序性！=随机性   真正的无序性，指的是元素在底层存储的位置是无序的
	 * 2.不可重复性     当向set之中添加相同的元素时，后面的加不进去
	 *   
	 *  3.说明：要求添加进Set中的元素所在的类，一定要重写equals()和hashCode()方法
	 *  进而保证Set中元素的不可重复性
	 *  
	 *  Set中元素是如何存储的  使用了哈希算法
	 *  当向Set中添加对象时，首先调用此对象所在类的hashCode()方法，计算此对象的哈希值
	 *  此哈希值决定了此对象在Set中存储位置。若此位置之前没有存储对象，则此对象直接存储到该位置
	 *  若此位置之前以有存储对象，再通过equals()比较这两个对象是否相同，if相同，后一个对象不可添加
	 *  
	 *  万一返回false  都存储，但是不建议
	 *  》要求，hashCode()方法要与equals()方法一致
	 */
	
	
	
	@Test
	public void testHashSet() {
		Set set=new HashSet();
		set.add(123);
		set.add(456);
		set.add("AAA");
		set.add("BBB");
		set.add(null);
		Person p1=new Person("GG",23);
		Person p2=new Person("MM",21);
		Person p3=new Person("GG",23);
		set.add(p1);
		set.add(p2);
		set.add(p3);
		System.out.println(p1.hashCode());
		System.out.println(p2.hashCode());
		System.out.println(p3.hashCode());

		System.out.println(set.size());
		System.out.println(set);
	}

}
