package comatxinxin0;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

import org.junit.Test;

/*
 * 1.流的分类
 * 按照数据流向不同                          输入流  输出流
 * 按照处理数据的单位不同               字节流  字符流（处理的文本文件）
 *    角色       （直接作用在文件）节点流  处理流
 *    
 * 2.IO的体系
 * 抽象基类                                        节点流（文件流）
 * InputStream         FileInputStream
 * OutputStream        FileOutputStream
 * Reader              FileReader
 * Writer              FileWriter
 * 
 */
public class TestFileInputOutputStream {
	
	@Test
	public void testFileOutputStream() {
		//1.创建一个File对象，表明要写入的文件位置
		//输出的物理文件可以不存在，若不存在，自动创建
		File file=new File("hello1.txt");
		//2.创建一个FileOutputStream的对象，将File的对象作为形参传递给FileOutputStream的构造器中
		FileOutputStream fos=null;
		try {
		    fos=new FileOutputStream(file);
		    //3.写入的操作
		    fos.write(new String("I love leaning").getBytes());
		} catch (Exception e) {
			e.printStackTrace();
		}finally {
			if(fos!=null) {
				try {
					//4.关闭输出流
					fos.close();
				} catch (IOException e) {
					// TODO 自动生成的 catch 块
					e.printStackTrace();
				}
			}
		}
		
		
		
	}
	
	@Test
	public void testFileInputStream3() {
		//try-catch后，将fil放外面成为全局变量
		FileInputStream fil=null;
		try {
			File file=new File("1.txt");
			fil=new FileInputStream(file);
			//读到一个数组当中,数据要写到的数组
			byte[] b=new byte[5];
			int len;//每次读入到byte中的字节的长度       没有返回-1
			while((len=fil.read(b))!=-1) {
				for(int i=0;i<b.length;i++) {
					System.out.print((char)b[i]);
				}
			}
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
		finally {
			if(fil!=null) 
			{
				try {
					fil.close();
				} catch (IOException e) {
					// TODO 自动生成的 catch 块
					e.printStackTrace();
				}
			}
		}
	}
	
	//使用try-catch的方式处理异常更合理:保证流的关闭操作一定可以执行
	@Test
	public void testFileInputStream2() {
		
		FileInputStream fis=null;
		try {
			File file=new File("1.txt");
			fis = new FileInputStream(file);
			int b;
			while((b=fis.read())!=-1) {
				System.out.println(b);
			}
		} catch (FileNotFoundException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
			
			
			
		} catch (IOException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}finally {
			try {
				fis.close();
			} catch (IOException e) {
				// TODO 自动生成的 catch 块
				e.printStackTrace();
			}
		}
		
	}
	
	
	//从硬盘存在的一个文件中，读取其内容到程序中，使用FileInputStream
	/*
	 * 注意
	 * 要读取的文件一定要存在，否则抛FileNotException
	 * 目前这个方式只支持英文，切会转化成ASCII 
	 */
	@Test
	public void testFileInputStream1() throws Exception {
		//1.创建一个File类的对象
		File file=new File("1.txt");
		//2.创建一个FileInputStream类的对象
		FileInputStream fis=new FileInputStream(file);
		//3.调用FileInputStream方法，实现file读取
		//read():读取一个文件的字节，当执行到文件结尾时，返回-1
		
//		int b=fis.read();
//		while(b!=-1) {
//			System.out.println((char)b);
//			b=fis.read();
//		}
		int b;
		while((b=fis.read())!=-1) {
			System.out.print((char)b);
		}
		//4.关闭相应的流
		fis.close();
	}

}
