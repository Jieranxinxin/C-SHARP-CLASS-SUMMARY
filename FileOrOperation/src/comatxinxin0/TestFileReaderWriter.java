package comatxinxin0;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

import org.junit.Test;

public class TestFileReaderWriter {
	
	//使用FileReader FileWrter可以实现文本文件的操作
	//对于非文本文件，只能使用字节流
	@Test
	public void testFileReaderWriter() {
		//1.输入流对应的文件src一定要存在，否则抛异常，输出流可以不存在，会自动创建
		FileReader fr=null;
		FileWriter fw=null;
		
		try {
			File src=new File("hello1.txt");
			File txt=new File("hello2.txt");
			//2.
			fr=new FileReader(src);
			fw=new FileWriter(txt);
			//3.
			char[] c=new char[5];
			int len;
			while((len=fr.read(c))!=-1) {
				//从0开始到len
				fw.write(c,0, len);
			}
		} catch (FileNotFoundException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		} catch (IOException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}finally {
			if(fw!=null) {
				try {
					fw.close();
				} catch (IOException e) {
					// TODO 自动生成的 catch 块
					e.printStackTrace();
				}
			}
			if(fr!=null) {
				try {
					fw.close();
				} catch (IOException e) {
					// TODO 自动生成的 catch 块
					e.printStackTrace();
				}
			}
		}
		
	}
	
	@Test
	public void testFileReader() {
		FileReader fr=null;
		try {
			File file=new File("1.txt");
			fr = new FileReader(file);
			char[] c=new char[2];
			int len;
			while((len=fr.read(c))!=-1) {
				String str =new String(c,0,len);
				System.out.print(str);
			}
		} catch (FileNotFoundException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		} catch (IOException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}finally {
			if(fr!=null) {
				try {
					fr.close();
				} catch (IOException e) {
					// TODO 自动生成的 catch 块
					e.printStackTrace();
				}
			}
		}
		
	}

}
