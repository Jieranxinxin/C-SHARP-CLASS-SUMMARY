package com;

public class Kp_operational_character {

	public static void main(String[] args) {
		
		//i=i*0.1  ������Ϊ�ó��Ĳ�������int����˫���ȸ���double��0.1
		
		int i=1;
		int j=1;
		i*=0.1;
		System.out.println(i);

		j=(int)(j*0.1);//0.1ת�������͵�0
		//��ͬ��
		j*=0.1;//���Ĭ��ת��������.����0
		System.out.println(j);
		
		//  %  ȡ�� +- ȡ���ڱ�ģ��
		short a=10;
		short b=11;
		//a=a+1;���벻ͨ��
		a=(short)(a+1);//����д�������㣬a��short->int->short
		b+=1;//������ʵ�����㣬�ֲ������a����������
		System.out.print(a+"\n");
		System.out.print(b);
		
		
		//����ô��ô���գ����н��Ϊ�����Ϊ��
		//��Ϊ����Ǹ�ֵ���ڿ�ͷ�Ѿ�����ֵ��
		//��Ϊ==�����н��Ϊ�����Ϊ��
		boolean c=false;
		if(c=true) {
			System.out.println("���Ϊ��");
		}
		else
			System.out.println("���Ϊ��");
		
		
		
		//&��&&������
		//&��������������ture����false�����˶����������
		//&&ȷ��һ�ˣ���һ�˲����������
		//����ʱ��ѡ  && ��ֹ�쳣�ͼ��
		boolean d=false;
		int d1=10;
		if(d & (d1++)>0) {
			System.out.println("GOOD");
		}else {
			System.out.println("OK!");
		}
		System.out.println(d1);

		int d2=10;
		if(d && (d2++)>0) {
			System.out.println("GOOD");
		}else {
			System.out.println("OK!");
		}
		System.out.println(d2);
		
		

		int m =12;
		int n=5;
		double k=(double)m/n;
		double e=m/5.0;

		System.out.println(k);
		System.out.print(e);
		

	}

}
