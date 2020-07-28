package com.xinxin.aixuexin0;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

/*
 * 异常处理的方式二
 * 在方法的声明处，显式的抛出该异常的对象类型
 * 格式：如public static void method2() throws FileNotFoundException,IOException
 * 当此方法内部出现异常时，会抛出一个异常类的对象，抛给方法的调用者
 * 异常的对象可以逐层向上抛，直至main中，当然在向上抛的过程中，可以再通过try-catch-finally进行处理
 * 
 * java的异常处理，抓抛模型
 * 1.抓，异常处理，两种方式(①try-catch-finally②throws加上一个异常的类型)
 * 2.抛，一旦执行过程中，出现异常，会抛出异常对象   两种，手动（throw+异常的对象），自动
 *    >异常类，既可以是现成的异常类，也可以是自创的
 * 
 * 
 * 上游排污，下游治污
 * throw   异常的生成阶段   手动抛出异常对象
 * throws  异常的处理方式    声明方法可能要抛出的各种异常类
 */
public class TestException2 {
	public static void main(String[] args){
		try {
			method2();
		} catch (IOException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}
	
	}
	
	public static void method2() throws FileNotFoundException,IOException{
		method1();
	}
	
	
	
	//IOException里面包含FileNotFoundException  多态的关系
	//把错误抛给方法的调用者
	public static void method1() throws FileNotFoundException,IOException{
		//这是一个文件，对应当前目录之下
		//可能出现文件找不到异常，编译时异常
		//这个错误解决方法可以抛出去throws FileNotFoundException
		FileInputStream fis=new FileInputStream(new File("hello.txt"));
		int b;
		while((b=fis.read())!=-1) {
			//转成字符的格式
			System.out.println((char)b);		
		}
		//这是一个流，要关闭
		fis.close();
	}
}
