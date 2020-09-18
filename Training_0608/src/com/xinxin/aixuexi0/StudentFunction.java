package com.xinxin.aixuexi0;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Scanner;

public class StudentFunction {

	Scanner sc = new Scanner(System.in);
	// ����--��̬����
	List<Student> stuList = new ArrayList<Student>();// ���Student����

	// ���ѧ����Ϣ
	public void addStudent() {

		// �����Ӧ��Ϣ������ѧ������
		System.out.println("������ѧ�ţ�");
		String stuId = sc.next();
		System.out.println("������������");
		String stuName = sc.next();
		System.out.println("�������Ա���/Ů/�����ǣ���");
		String stuSex = sc.next();
		System.out.println("������绰��");
		String stuPhoneNum = sc.next();
		System.out.println("������༶��");
		String stuClass = sc.next();
		Student stu = new Student(stuId, stuName, stuSex, stuPhoneNum, stuClass);

		// ������д���ļ�
		// ���ж��ļ��Ƿ���ڣ����򴴽�
		checkFileExists();

		// ��ȡ�ļ��е�����
		stuList = readFromFile();

		// ���¼�¼д���ļ�
		String str = stu.getStuId() + " " + stu.getStuName() + " " + stu.getStuSex() + " " + stu.getStuPhoneNum() + " "
				+ stu.getStuClass();

		// ��������
		for (int i = 0; i < stuList.size(); i++) {
			Student stu1 = stuList.get(i);
			if (stuId.equals(stu1.getStuId())) {
				System.out.println("�������ڹ���ϵͳ");
				return;// �����÷���
			}

		}

		// �����ݼ����ļ����ж��Ƿ��ǵ�һ��д�룬��ֱ�Ӽӣ���׷��
		if (stuList.size() > 0) {//
			str = "\r\n" + str;// ׷�� ֮ǰ�Ȼ��� ��java�бȽ����⣬Ҫ��������б�����д��\r\n
		}
		writeToFile(str, true);// ��׷�ӵķ�ʽд������
		System.out.println("��Ϣ��ӳɹ���\n");
		printMessageBiaotou();
		printMessage(stu);
		printMessageBiaowei();
	}

	// ��ѯ����ѧ����Ϣ
	public void selectOne() {
		System.out.println("������ѧ�ţ�");
		String stuId = sc.next();
		stuList = readFromFile();// ������
		if (stuList.size() > 0) {
			for (int i = 0; i < stuList.size(); i++) {// �Ӽ������������
				Student stu = stuList.get(i);
				if (stu.getStuId().equals(stuId)) {
					printMessageBiaotou();
					printMessage(stu);
					printMessageBiaowei();
					break;
				}
				if (i == stuList.size() - 1) {// �ҵ����Ҳû�ҵ���Ӧ����������ʾ�޸�����¼�������÷���
					System.out.println("�޸�����Ϣ");
					return;
				}

			}
		} else {
			System.out.println("�ļ�Ϊ�գ���ѧ����Ϣ!");
		}
	}

	// ��ѯAll
	public void selectAll() {
		stuList = readFromFile();
		if (stuList.size() > 0) {
			printMessageBiaotou();
			Iterator<Student> ite = stuList.iterator();// ������
			while (ite.hasNext()) {
				System.out.println(ite.next());
			}
			printMessageBiaowei();
		} else {
			System.out.println("�ļ�Ϊ�գ���ѧ����Ϣ!");
		}
	}

	// �޸�ѧ����Ϣ
	public void updateStu() {
		System.out.println("������Ҫ�޸�ѧ����ѧ�ţ�");
		String stuId = sc.next();
		stuList = readFromFile();
		if (stuList.size() > 0) {
			for (int i = 0; i < stuList.size(); i++) {
				Student stu = stuList.get(i);
				if (stu.getStuId().equals(stuId)) {// �������ɱ�
					System.out.println("�������޸ĵ�������");
					String gname = sc.next();
					System.out.println("�������޸ĵ��Ա�");
					String gsex = sc.next();
					System.out.println("�������޸ĳɵİ༶��");
					String gclass = sc.next();
					System.out.println("�������޸ĳɵĵ绰��");
					String gphone = sc.next();
					stu.setStuClass(gclass);
					stu.setStuName(gname);
					stu.setStuSex(gsex);
					stu.setStuPhoneNum(gphone);
					stuList.set(i, stu);// ���¼������Ӧ������
					break;
				}
				if(i==stuList.size()-1) {
					System.out.println("���޴�ѧ��������������");
					return;
				}
			}
			//�޸ĺ󣬰Ѽ����е���Ϣ����д���ļ����Դﵽ���ǵ�Ŀ��
			String writerStr="";
			
			for(int i=0;i<stuList.size();i++) {
				Student stu=stuList.get(i);
				writerStr=writerStr+stu.getStuId()+" "+stu.getStuName()+" "+stu.getStuSex()+" "+stu.getStuPhoneNum()+" "+stu.getStuClass();
				if(i!=stuList.size()-1) {//�����һ����¼����
					writerStr=writerStr+"\r\n";
				}
			}
			writeToFile(writerStr,false);
			System.out.println("ѧ����Ϣ�޸ĳɹ���");//����
			
		} else {
			System.out.println("����Ϊ�գ�");
		}

	}

	//ɾ��ѧ����Ϣ
	public void delStudent() {
		System.out.println("����������ɾ��ѧ����Ϣ��ѧ��");
		String stuId=sc.next();
		String stuStr="";
		stuList=readFromFile();
		if(stuList.size()>0) {
			//�����Ƿ���ڸü�¼��������Ӧ����
			for(int i=0;i<stuList.size();i++) {
				Student stu=stuList.get(i);
				if(stu.getStuId().equals(stuId)) {
					stuList.remove(stu);
					break;
				}
				if(i==stuList.size()-1) {
					System.out.println("�޸�����¼��������ѡ��");
					return;
				}
			}
			
			//����֮���ٽ�����д���ļ�
			for(int i=0;i<stuList.size();i++) {
				Student stu=stuList.get(i);
				stuStr=stuStr+stu.getStuId()+" "+stu.getStuName()+" "+stu.getStuSex()+" "+stu.getStuPhoneNum()+" "+stu.getStuClass();
				if(i!=stuList.size()-1) {
					stuStr=stuStr+"\r\n";
				}
			}
			writeToFile(stuStr,false);
			System.out.println("ɾ���ɹ�!");
		}else {
			System.out.println("No record! Please re-enter");
		}
		
	}
	/*
	 * �ж��̷����ļ��Ƿ���� 1.�ж��ļ�Ŀ¼�Ƿ���ڣ�������mkdir()���� 2.�ж��ļ��Ƿ���ڣ�������createNewFile()����
	 */
	private void checkFileExists() {
		File fileDir = new File("D:\\Learning\\TestFile");
		File file = new File("D:\\Learning\\TestFile\\StudentManage.txt");

		if (!fileDir.exists()) {// �ж�Ŀ¼�Ƿ���ڣ����򴴽�
			fileDir.mkdirs();
		}
		if (!file.exists()) {// �ж��ļ��Ƿ����
			try {
				file.createNewFile();
			} catch (IOException e) {
				// TODO �Զ����ɵ� catch ��
				e.printStackTrace();
			}
		}
	}

	private List readFromFile() {
		List list = new ArrayList();
		FileReader fr = null;// �ַ�������
		BufferedReader br = null;// �ַ�����������ȡ���ݵ�ʱ������Ϊ��λ
		String readString = "";// ���ÿ��һ�е�����
		String[] stuPropertyArray = new String[1024];// ��ÿ����¼������
		try {
			fr = new FileReader("D:\\Learning\\TestFile\\StudentManage.txt");// �����ַ�������
			br = new BufferedReader(fr);// ����������
			while ((readString = br.readLine()) != null) {// ѭ������ÿ�ζ�һ�У���Ϊ�գ��ż�����
				stuPropertyArray = readString.split(" ");
				Student stu = new Student();
				stu.setStuId(stuPropertyArray[0]);
				stu.setStuName(stuPropertyArray[1]);
				stu.setStuSex(stuPropertyArray[2]);
				stu.setStuPhoneNum(stuPropertyArray[3]);
				stu.setStuClass(stuPropertyArray[4]);
				list.add(stu);
			}
			br.close();
			fr.close();
		} catch (FileNotFoundException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		} catch (IOException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		}
		return list;
	}

	private void writeToFile(String date, boolean mode) {
		FileWriter fw = null;
		BufferedWriter bw = null;

		try {
			fw = new FileWriter("D:\\Learning\\TestFile\\StudentManage.txt", mode);// modeĬ��false,д������ݸ���ԭ�����ݣ�true׷��
			bw = new BufferedWriter(fw);
			bw.write(date);
			bw.close();
			fw.close();
		} catch (IOException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		}

	}

	private void printMessageBiaotou() {
		System.out.println("********************************");
		System.out.println("ѧ��:\t����:\t�Ա�\t��ϵ��ʽ\t�༶");
	}

	private void printMessage(Student stu) {
		System.out.println(stu.getStuId() + "\t" + stu.getStuName() + "\t" + stu.getStuSex() + "\t"
				+ stu.getStuPhoneNum() + "\t" + stu.getStuClass());
	}

	private void printMessageBiaowei() {
		System.out.println("********************************\n");
	}

}
