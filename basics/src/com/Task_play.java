package com;

import java.util.Random;
import java.util.Scanner;

public class Task_play {
	public static void main(String[] args) {
		
		//��ʼǰ����ʾ
		
		System.out.println("-----------��������Ϸ-----------"+"\n"+
		"-----Dear,����Ҫ��ʼ��Ϸ��Ŷ ��-----");
		System.out.println("-----�����;��Ҫ�˳�,������: 0-----");
		System.out.println();

		//�����������Χ
		
		int randNum;
		System.out.print("�����뿪ʼ��Χ��");
    	Scanner input=new Scanner(System.in);
    	int START=input.nextInt();
    	System.out.print("�����������Χ��");
    	int END=input.nextInt();
        Random random = new Random();    //����Random�����          
        randNum = random.nextInt(END - START + 1) + START;   //���������
         
   
        
        System.out.println("����"+START+"~"+END+"��Χ��������µ���:");
        while(true) {
        int guessNum=input.nextInt();
        if(guessNum!=0) {
        	//���뷨���´���֮�󣬷�Χ��С
        	if(guessNum>randNum) {
        		System.out.print("�´���Ŷ��\n");
        		System.out.println("����"+START+"~"+guessNum+"��Χ��������µ���:");
        		continue;
        	}else if(guessNum<randNum) {
        		System.out.print("��С��Ŷ��\n");
        		System.out.println("����"+guessNum+"~"+END+"��Χ��������µ���:");
        		continue;
        	}
        	/*else if(guessNum>END||guessNum<START) {
        		System.out.println("����������ݲ��ڷ�Χ�ڣ�����������");
        		continue;
        	}*/
        	else {
        		System.out.print("WOW!�¶��ˣ�");
        		break;
        	}
        }else {
        	System.out.println("---------- ��Ϸ������ -----------");
        	break;
        }
		
	}
	}
}
