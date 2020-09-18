package comatxinxin0;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

import org.junit.Test;

/*
 * 1.���ķ���
 * ������������ͬ                          ������  �����
 * ���մ������ݵĵ�λ��ͬ               �ֽ���  �ַ�����������ı��ļ���
 *    ��ɫ       ��ֱ���������ļ����ڵ���  ������
 *    
 * 2.IO����ϵ
 * �������                                        �ڵ������ļ�����
 * InputStream         FileInputStream
 * OutputStream        FileOutputStream
 * Reader              FileReader
 * Writer              FileWriter
 * 
 */
public class TestFileInputOutputStream {
	
	@Test
	public void testFileOutputStream() {
		//1.����һ��File���󣬱���Ҫд����ļ�λ��
		//����������ļ����Բ����ڣ��������ڣ��Զ�����
		File file=new File("hello1.txt");
		//2.����һ��FileOutputStream�Ķ��󣬽�File�Ķ�����Ϊ�βδ��ݸ�FileOutputStream�Ĺ�������
		FileOutputStream fos=null;
		try {
		    fos=new FileOutputStream(file);
		    //3.д��Ĳ���
		    fos.write(new String("I love leaning").getBytes());
		} catch (Exception e) {
			e.printStackTrace();
		}finally {
			if(fos!=null) {
				try {
					//4.�ر������
					fos.close();
				} catch (IOException e) {
					// TODO �Զ����ɵ� catch ��
					e.printStackTrace();
				}
			}
		}
		
		
		
	}
	
	@Test
	public void testFileInputStream3() {
		//try-catch�󣬽�fil�������Ϊȫ�ֱ���
		FileInputStream fil=null;
		try {
			File file=new File("1.txt");
			fil=new FileInputStream(file);
			//����һ�����鵱��,����Ҫд��������
			byte[] b=new byte[5];
			int len;//ÿ�ζ��뵽byte�е��ֽڵĳ���       û�з���-1
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
					// TODO �Զ����ɵ� catch ��
					e.printStackTrace();
				}
			}
		}
	}
	
	//ʹ��try-catch�ķ�ʽ�����쳣������:��֤���Ĺرղ���һ������ִ��
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
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
			
			
			
		} catch (IOException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		}finally {
			try {
				fis.close();
			} catch (IOException e) {
				// TODO �Զ����ɵ� catch ��
				e.printStackTrace();
			}
		}
		
	}
	
	
	//��Ӳ�̴��ڵ�һ���ļ��У���ȡ�����ݵ������У�ʹ��FileInputStream
	/*
	 * ע��
	 * Ҫ��ȡ���ļ�һ��Ҫ���ڣ�������FileNotException
	 * Ŀǰ�����ʽֻ֧��Ӣ�ģ��л�ת����ASCII 
	 */
	@Test
	public void testFileInputStream1() throws Exception {
		//1.����һ��File��Ķ���
		File file=new File("1.txt");
		//2.����һ��FileInputStream��Ķ���
		FileInputStream fis=new FileInputStream(file);
		//3.����FileInputStream������ʵ��file��ȡ
		//read():��ȡһ���ļ����ֽڣ���ִ�е��ļ���βʱ������-1
		
//		int b=fis.read();
//		while(b!=-1) {
//			System.out.println((char)b);
//			b=fis.read();
//		}
		int b;
		while((b=fis.read())!=-1) {
			System.out.print((char)b);
		}
		//4.�ر���Ӧ����
		fis.close();
	}

}
