package test_com.xinxin.aixuei;

import java.util.Random;
import java.util.Scanner;

public class Game {
	public static void main(String[] args) {

		// ׼��
		char ranchar;
		String guesscors;
		int intergral = 100;
		Random random = new Random();
		StringBuffer SBuffer = new StringBuffer();
		Scanner input = new Scanner(System.in);
		System.out.println("------------------");
		System.out.println("----Game Start----\n------------------");
		System.out.println("-- ��Ϸ�ܻ���Ϊ ��" + intergral+"--");

		// 1.���������ĸ
		// 2.����ѭ�����i��
		for (int i = 0; i < 10; i++) {
			ranchar = (char) ('A' + random.nextInt(26));
			// System.out.println(ranchar);

			// 5.����λ��ǰ �����ӳ��ַ���
			SBuffer.append(ranchar);
			// System.out.println(SBuffer.append(ranchar));����׷��--> AA
		}

		// 3.�����ַ�		
		// 4.�жϴ��� ��ôȥ�жϣ�ͨ������λ��
		while (SBuffer.length() > 0 && intergral > 0) {
			System.out.println("--"+SBuffer);
			System.out.println("--     "+"�����룺"+"          --");
			guesscors = input.next();

			// 6������λ�� �����ִ�Сд �ڲ�����
			int index = SBuffer.indexOf(guesscors.toUpperCase());
			// 7.����λ�ã��ж����Ƿ���� ������ȥ�������ڷ���
			if (index >= 0) {
				intergral += 10;
				System.out.println("--  "+"��ʱ����Ϊ��" + intergral+"--");
				SBuffer.delete(index,index+guesscors.length());
			} else {
				intergral -= 10;
				System.out.println("--   �����ַ�������    --");
				System.out.println("--   "+"��ʱ����Ϊ��" + intergral+" --");
			}
		}
		System.out.println("----Game Over----");

	}

}
