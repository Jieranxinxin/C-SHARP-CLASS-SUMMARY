package comatxinxin0;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

import org.junit.Test;

public class TestFileReaderWriter {
	
	//ʹ��FileReader FileWrter����ʵ���ı��ļ��Ĳ���
	//���ڷ��ı��ļ���ֻ��ʹ���ֽ���
	@Test
	public void testFileReaderWriter() {
		//1.��������Ӧ���ļ�srcһ��Ҫ���ڣ��������쳣����������Բ����ڣ����Զ�����
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
				//��0��ʼ��len
				fw.write(c,0, len);
			}
		} catch (FileNotFoundException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		} catch (IOException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		}finally {
			if(fw!=null) {
				try {
					fw.close();
				} catch (IOException e) {
					// TODO �Զ����ɵ� catch ��
					e.printStackTrace();
				}
			}
			if(fr!=null) {
				try {
					fw.close();
				} catch (IOException e) {
					// TODO �Զ����ɵ� catch ��
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
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		} catch (IOException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		}finally {
			if(fr!=null) {
				try {
					fr.close();
				} catch (IOException e) {
					// TODO �Զ����ɵ� catch ��
					e.printStackTrace();
				}
			}
		}
		
	}

}
