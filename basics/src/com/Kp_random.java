package com;

import java.util.Random;
import java.util.Scanner;

//����һ����X��Y֮����������������

/**
* һ��˼·��
* 1�������������Ҫʹ�õ�Java�������е�Random�ࡣ
* 2��Ҫ�������x��y֮�����������ָ����Χ����ʹ��Random���е�nextInt(int n)������
* 3���÷������ɴ�0����������n����������֮��������������һ��α��������������������������
* 4����x��Ϊ0������Ҫ�������������x������n��ֵҲ��Ҫ����1���ȥx��������ŷ���Ҫ��ķ�Χ��
* ����ʵ�֣�
* 1������x��y��ֵ���޸ĸ�ֵ���������ͬ��Χ��������
* 2������Random�е�nextInt(int n)�����������������
* 3���������ӡ������̨��
* */
public class Kp_random {
    public static void main(String[] args) {
    	System.out.print("�����뿪ʼ��Χ��");
    	Scanner input=new Scanner(System.in);
    	int START=input.nextInt();
    	System.out.print("�����������Χ��");
    	int END=input.nextInt();
        // TODO Auto-generated method stub
         
        //����Random�����
        Random random = new Random();              
         
        //���������
        int number = random.nextInt(END - START + 1) + START;
         
        //��ӡ�����
        System.out.println("����һ��"+START+"��"+END+"֮������������"+number);
         
    }
}