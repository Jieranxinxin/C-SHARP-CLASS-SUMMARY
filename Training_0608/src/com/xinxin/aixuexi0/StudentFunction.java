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
	// 集合--动态数组
	List<Student> stuList = new ArrayList<Student>();// 存放Student对象

	// 添加学生信息
	public void addStudent() {

		// 添加相应信息，创建学生对象
		System.out.println("请输入学号：");
		String stuId = sc.next();
		System.out.println("请输入姓名：");
		String stuName = sc.next();
		System.out.println("请输入性别（男/女/都不是）：");
		String stuSex = sc.next();
		System.out.println("请输入电话：");
		String stuPhoneNum = sc.next();
		System.out.println("请输入班级：");
		String stuClass = sc.next();
		Student stu = new Student(stuId, stuName, stuSex, stuPhoneNum, stuClass);

		// 将数据写入文件
		// 先判断文件是否存在，无则创建
		checkFileExists();

		// 读取文件中的内容
		stuList = readFromFile();

		// 将新记录写入文件
		String str = stu.getStuId() + " " + stu.getStuName() + " " + stu.getStuSex() + " " + stu.getStuPhoneNum() + " "
				+ stu.getStuClass();

		// 设置主键
		for (int i = 0; i < stuList.size(); i++) {
			Student stu1 = stuList.get(i);
			if (stuId.equals(stu1.getStuId())) {
				System.out.println("该生已在管理系统");
				return;// 结束该方法
			}

		}

		// 将数据加入文件，判断是否是第一次写入，是直接加，否追加
		if (stuList.size() > 0) {//
			str = "\r\n" + str;// 追加 之前先换行 在java中比较特殊，要想输出换行必须是写成\r\n
		}
		writeToFile(str, true);// 以追加的方式写入内容
		System.out.println("信息添加成功！\n");
		printMessageBiaotou();
		printMessage(stu);
		printMessageBiaowei();
	}

	// 查询单个学生信息
	public void selectOne() {
		System.out.println("请输入学号：");
		String stuId = sc.next();
		stuList = readFromFile();// 读内容
		if (stuList.size() > 0) {
			for (int i = 0; i < stuList.size(); i++) {// 从集合里查找主键
				Student stu = stuList.get(i);
				if (stu.getStuId().equals(stuId)) {
					printMessageBiaotou();
					printMessage(stu);
					printMessageBiaowei();
					break;
				}
				if (i == stuList.size() - 1) {// 找到最后，也没找到相应的主键，提示无该生记录，结束该方法
					System.out.println("无该生信息");
					return;
				}

			}
		} else {
			System.out.println("文件为空，无学生信息!");
		}
	}

	// 查询All
	public void selectAll() {
		stuList = readFromFile();
		if (stuList.size() > 0) {
			printMessageBiaotou();
			Iterator<Student> ite = stuList.iterator();// 迭代器
			while (ite.hasNext()) {
				System.out.println(ite.next());
			}
			printMessageBiaowei();
		} else {
			System.out.println("文件为空，无学生信息!");
		}
	}

	// 修改学生信息
	public void updateStu() {
		System.out.println("请输入要修改学生的学号：");
		String stuId = sc.next();
		stuList = readFromFile();
		if (stuList.size() > 0) {
			for (int i = 0; i < stuList.size(); i++) {
				Student stu = stuList.get(i);
				if (stu.getStuId().equals(stuId)) {// 主键不可变
					System.out.println("请输入修改的姓名：");
					String gname = sc.next();
					System.out.println("请输入修改的性别");
					String gsex = sc.next();
					System.out.println("请输入修改成的班级：");
					String gclass = sc.next();
					System.out.println("请输入修改成的电话：");
					String gphone = sc.next();
					stu.setStuClass(gclass);
					stu.setStuName(gname);
					stu.setStuSex(gsex);
					stu.setStuPhoneNum(gphone);
					stuList.set(i, stu);// 更新集合里对应的内容
					break;
				}
				if(i==stuList.size()-1) {
					System.out.println("查无此学生，请重新输入");
					return;
				}
			}
			//修改后，把集合中的信息重新写入文件，以达到覆盖的目的
			String writerStr="";
			
			for(int i=0;i<stuList.size();i++) {
				Student stu=stuList.get(i);
				writerStr=writerStr+stu.getStuId()+" "+stu.getStuName()+" "+stu.getStuSex()+" "+stu.getStuPhoneNum()+" "+stu.getStuClass();
				if(i!=stuList.size()-1) {//非最后一条记录换行
					writerStr=writerStr+"\r\n";
				}
			}
			writeToFile(writerStr,false);
			System.out.println("学生信息修改成功！");//覆盖
			
		} else {
			System.out.println("数据为空！");
		}

	}

	//删除学生信息
	public void delStudent() {
		System.out.println("请输入所需删除学生信息的学号");
		String stuId=sc.next();
		String stuStr="";
		stuList=readFromFile();
		if(stuList.size()>0) {
			//查找是否存在该记录，进行相应操作
			for(int i=0;i<stuList.size();i++) {
				Student stu=stuList.get(i);
				if(stu.getStuId().equals(stuId)) {
					stuList.remove(stu);
					break;
				}
				if(i==stuList.size()-1) {
					System.out.println("无该生记录，请重新选择");
					return;
				}
			}
			
			//操作之后再将数据写入文件
			for(int i=0;i<stuList.size();i++) {
				Student stu=stuList.get(i);
				stuStr=stuStr+stu.getStuId()+" "+stu.getStuName()+" "+stu.getStuSex()+" "+stu.getStuPhoneNum()+" "+stu.getStuClass();
				if(i!=stuList.size()-1) {
					stuStr=stuStr+"\r\n";
				}
			}
			writeToFile(stuStr,false);
			System.out.println("删除成功!");
		}else {
			System.out.println("No record! Please re-enter");
		}
		
	}
	/*
	 * 判断盘符中文件是否存在 1.判断文件目录是否存在，无则用mkdir()创建 2.判断文件是否存在，无则用createNewFile()创建
	 */
	private void checkFileExists() {
		File fileDir = new File("D:\\Learning\\TestFile");
		File file = new File("D:\\Learning\\TestFile\\StudentManage.txt");

		if (!fileDir.exists()) {// 判断目录是否存在，无则创建
			fileDir.mkdirs();
		}
		if (!file.exists()) {// 判断文件是否存在
			try {
				file.createNewFile();
			} catch (IOException e) {
				// TODO 自动生成的 catch 块
				e.printStackTrace();
			}
		}
	}

	private List readFromFile() {
		List list = new ArrayList();
		FileReader fr = null;// 字符输入流
		BufferedReader br = null;// 字符缓冲流，读取数据的时候以行为单位
		String readString = "";// 存放每读一行的内容
		String[] stuPropertyArray = new String[1024];// 存每个记录的属性
		try {
			fr = new FileReader("D:\\Learning\\TestFile\\StudentManage.txt");// 创建字符输入流
			br = new BufferedReader(fr);// 创建缓冲流
			while ((readString = br.readLine()) != null) {// 循环读，每次读一行，不为空，放集合中
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
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		} catch (IOException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}
		return list;
	}

	private void writeToFile(String date, boolean mode) {
		FileWriter fw = null;
		BufferedWriter bw = null;

		try {
			fw = new FileWriter("D:\\Learning\\TestFile\\StudentManage.txt", mode);// mode默认false,写入的内容覆盖原有内容，true追加
			bw = new BufferedWriter(fw);
			bw.write(date);
			bw.close();
			fw.close();
		} catch (IOException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}

	}

	private void printMessageBiaotou() {
		System.out.println("********************************");
		System.out.println("学号:\t姓名:\t性别\t联系方式\t班级");
	}

	private void printMessage(Student stu) {
		System.out.println(stu.getStuId() + "\t" + stu.getStuName() + "\t" + stu.getStuSex() + "\t"
				+ stu.getStuPhoneNum() + "\t" + stu.getStuClass());
	}

	private void printMessageBiaowei() {
		System.out.println("********************************\n");
	}

}
