package banking;

import java.util.Scanner;

public class TestBanking {
	public static void main(String[] args) {
		
		Scanner x = new Scanner(System.in);
		System.out.println("����0����!�����������ֽ��в���");
		//System.out.println("��Ǯ����1,ȡǮ������2");
		int y = x.nextInt();
		System.out.println("ִ�в�����");
		Account a = new Account(500);
		try {
		//ouabcter:
		while (y != 0) {
			
			//System.out.println("��Ǯ����1,ȡǮ������2");
			
			System.out.println("��Ǯ����1,ȡǮ������2,����0����!");

			int w = x.nextInt();
			if (w == 2) {
				System.out.println("����������ȡ��");
				double i = x.nextInt();
				// System.out.println(i);
				a.withdraw(i);
				//continue;
			} else if (w == 1) {
				System.out.println("�������������");
				double j = x.nextInt();
				a.deposit(j);
				//continue;
			} else if(w==0){
				break;
			}else {
				System.out.println("�������ݲ����ڣ��޷����з��������������룺");
			}
		}
		}catch(Exception e){
			System.out.println("����������������");	
		}
	}
}
