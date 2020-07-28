package comatxinxin0;
import java.io.File;
import java.io.IOException;
import java.util.Date;

import org.junit.Test;
/*
 * java.io.File类
 * 
 * 1.凡是与输入、输出相关的类、接口等都定义在java.io包下
 * 2.File是一个类，可以由构造器创建其对象        此对象对应一个文件或文件目录
 * 3.File对象与平台无关
 * 4.File中的方法，仅涉及到如何创建、删除、重命名。涉及文件内容，File无能为力，必须由io流完成
 * 5.File类的对象常作为io流的具体类的构造器的形参
 */
public class TestFile {
	
	/*
	 * 路径
	 * 绝对路径 ：包括盘符在内的完整的文件路径
	 * 相对路径：在当前文件目录下的文件路径
	 */
	
	/*
	 * 创建文件  createNewFile
	 * 创建文件目录  mkdir()
	 * 如果上层文件不在创建   mkdirs()
	 * 删除   delete
	 * 以字符串的形式读出来    list
	 * 以文件形式   listFiles
	 * 
	 * 
	 * 
	 * 
	 */
	@Test
	public void test3() throws IOException {
		File file1=new File("D:\\Learning\\TestFile\\1.txt");
		
		//删文件
		System.out.println(file1.delete());
		
		if(!file1.exists()) {
			//创建文件目录
			boolean b =file1.mkdir();
			System.out.println(b);
		}
		
		File file2=new File("D:\\Learning\\TestFile\\io");
		if(!file2.exists()) {
			//创建文件
			boolean b1=file2.createNewFile();
			System.out.println(b1);
		}

		File file3=new File("D:\\Learning\\TestFile") ;
		String[] str=file3.list();
		for(int i=0;i<str.length;i++) {
			System.out.println(str[i]);
		}
		File[] files=file3.listFiles();
		for(int i=0;i<str.length;i++) {
			System.out.println(files[i].getName());
		}
	}
	
	
	@Test
	public void test2() {
		File file1=new File("D:\\Learning\\TestFile\\1.txt");
		File file2=new File("D:\\Learning\\TestFile\\target_path1");
		//3.判断这个文件是否存在
		System.out.println(file1.exists());
		//是否可写、可读
		System.out.println(file1.canWrite());
		System.out.println(file1.canRead());
		//是否是一个文件
		System.out.println(file1.isFile());
		//是否是一个文件目录
		System.out.println(file1.isDirectory());
		//最后的修改时间
		System.out.println(new Date(file1.lastModified()));
		//
		System.out.println(file1.length());
	}
	
	
	
	
	
	@Test
	public void test1() {
		//  跨平台  可以“\\”或“/”
		File file1=new File("D:\\Learning\\TestFile\\1.txt");
		File file2=new File("hello.txt");
		File file3=new File("D:\\Learning\\TestFile\\path");
		File file4=new File("D:\\Learning\\TestFile\\target_path1");
		
		//1. 获取文件名  路径      绝对路径  返回此抽象路径名的绝对路径名形式    上一层文件目录   
		System.out.println(file1.getName());
		System.out.println(file1.getPath());
		System.out.println(file1.getAbsoluteFile());
		System.out.println(file1.getAbsolutePath());
		System.out.println(file1.getParent());

		System.out.println();
		System.out.println(file3.getName());
		System.out.println(file3.getPath());
		System.out.println(file3.getAbsoluteFile());
		System.out.println(file3.getAbsolutePath());
		System.out.println(file3.getParent());
		
		//2。重命名
		//都是文件或文件目录，跟相对绝对路径无关
		//file.renameTo(file2):file1重命名为file2.要求：file1文件一定存在，file2文件一定不存在  返回布尔类型
		boolean b=file1.renameTo(file2);
		boolean b1=file3.renameTo(file4);
		System.out.println(b1);
		
	}

}
