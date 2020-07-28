package com.xinxin;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Test_Listinput {
	public static void main(String[] args) {
		List list=new ArrayList();
		list.add("A");
		list.add("B");
		list.add("C");
		list.add("D");
		list.add("E");
		Iterator iterator= list.iterator();
		while(iterator.hasNext()) {
			System.out.println(iterator.next());
		}
	}
	

}
