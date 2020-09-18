package comatxinxin0;
import java.io.File;
import java.io.IOException;
import java.util.Date;

import org.junit.Test;
/*
 * java.io.File��
 * 
 * 1.���������롢�����ص��ࡢ�ӿڵȶ�������java.io����
 * 2.File��һ���࣬�����ɹ��������������        �˶����Ӧһ���ļ����ļ�Ŀ¼
 * 3.File������ƽ̨�޹�
 * 4.File�еķ��������漰����δ�����ɾ�������������漰�ļ����ݣ�File����Ϊ����������io�����
 * 5.File��Ķ�����Ϊio���ľ�����Ĺ��������β�
 */
public class TestFile {
	
	/*
	 * ·��
	 * ����·�� �������̷����ڵ��������ļ�·��
	 * ���·�����ڵ�ǰ�ļ�Ŀ¼�µ��ļ�·��
	 */
	
	/*
	 * �����ļ�  createNewFile
	 * �����ļ�Ŀ¼  mkdir()
	 * ����ϲ��ļ����ڴ���   mkdirs()
	 * ɾ��   delete
	 * ���ַ�������ʽ������    list
	 * ���ļ���ʽ   listFiles
	 * 
	 * 
	 * 
	 * 
	 */
	@Test
	public void test3() throws IOException {
		File file1=new File("D:\\Learning\\TestFile\\1.txt");
		
		//ɾ�ļ�
		System.out.println(file1.delete());
		
		if(!file1.exists()) {
			//�����ļ�Ŀ¼
			boolean b =file1.mkdir();
			System.out.println(b);
		}
		
		File file2=new File("D:\\Learning\\TestFile\\io");
		if(!file2.exists()) {
			//�����ļ�
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
		//3.�ж�����ļ��Ƿ����
		System.out.println(file1.exists());
		//�Ƿ��д���ɶ�
		System.out.println(file1.canWrite());
		System.out.println(file1.canRead());
		//�Ƿ���һ���ļ�
		System.out.println(file1.isFile());
		//�Ƿ���һ���ļ�Ŀ¼
		System.out.println(file1.isDirectory());
		//�����޸�ʱ��
		System.out.println(new Date(file1.lastModified()));
		//
		System.out.println(file1.length());
	}
	
	
	
	
	
	@Test
	public void test1() {
		//  ��ƽ̨  ���ԡ�\\����/��
		File file1=new File("D:\\Learning\\TestFile\\1.txt");
		File file2=new File("hello.txt");
		File file3=new File("D:\\Learning\\TestFile\\path");
		File file4=new File("D:\\Learning\\TestFile\\target_path1");
		
		//1. ��ȡ�ļ���  ·��      ����·��  ���ش˳���·�����ľ���·������ʽ    ��һ���ļ�Ŀ¼   
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
		
		//2��������
		//�����ļ����ļ�Ŀ¼������Ծ���·���޹�
		//file.renameTo(file2):file1������Ϊfile2.Ҫ��file1�ļ�һ�����ڣ�file2�ļ�һ��������  ���ز�������
		boolean b=file1.renameTo(file2);
		boolean b1=file3.renameTo(file4);
		System.out.println(b1);
		
	}

}
