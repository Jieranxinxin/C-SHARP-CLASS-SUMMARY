package com.xinxin.aixuexi0;

import java.util.Scanner;

public class StuManage {
	public static void main(String[] args) {
		
		StudentFunction StuFunction=new StudentFunction();
		Scanner input=new Scanner(System.in);
		int num;
		
		do {
			printMenu();
			num=input.nextInt();
			switch(num) {
			
			case 1:
				//��
				StuFunction.addStudent();
				break;
			case 2:
				//ɾ
				StuFunction.delStudent();
				break;
			case 3:
				//��
				StuFunction.updateStu();
				break;
			case 4:
				//�� One
				StuFunction.selectOne();
				break;
			case 5:
				//��  All
				StuFunction.selectAll();
				break;
			case 0:
				System.out.println("Dear Friend,Are you Exit?(��y�˳��������������)");
				String choice=input.next();
				if(choice.equalsIgnoreCase("y")) {
					System.out.println("ллʹ�ã�");
					System.exit(0);//��Java�����������ͣ��
				}
				break;
			default:
				System.out.println("���ڷ�Χ�ڣ����������룺");
				break;
			}
		}while(true);
	}

	private static void printMenu() {
		System.out.println("-------      ������       ѧ������ϵͳ V 1.0     -----");
		System.out.println("-------------------------------------------");
		System.out.println("-------1.����ѧ����Ϣ                        2.ɾ��ѧ����Ϣ        ----");
		System.out.println("-------3.�޸�ѧ����Ϣ                        4.��ѯ����ѧ����    ----");
		System.out.println("-------5.��ѯȫ��ѧ����Ϣ                 0.�˳�ϵͳ               ----");
		System.out.println("-------------------------------------------");
		System.out.println("-------��ѡ��                                                                         ----");

	}

}