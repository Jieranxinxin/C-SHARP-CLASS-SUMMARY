package test_com.xinxin.aixuei;

import java.util.Random;
import java.util.Scanner;

public class Game {
	public static void main(String[] args) {

		// 准备
		char ranchar;
		String guesscors;
		int intergral = 100;
		Random random = new Random();
		StringBuffer SBuffer = new StringBuffer();
		Scanner input = new Scanner(System.in);
		System.out.println("------------------");
		System.out.println("----Game Start----\n------------------");
		System.out.println("-- 游戏总积分为 ：" + intergral+"--");

		// 1.产生随机字母
		// 2.让其循环输出i次
		for (int i = 0; i < 10; i++) {
			ranchar = (char) ('A' + random.nextInt(26));
			// System.out.println(ranchar);

			// 5.查找位置前 先连接成字符串
			SBuffer.append(ranchar);
			// System.out.println(SBuffer.append(ranchar));连续追加--> AA
		}

		// 3.输入字符		
		// 4.判断存在 怎么去判断，通过查找位置
		while (SBuffer.length() > 0 && intergral > 0) {
			System.out.println("--"+SBuffer);
			System.out.println("--     "+"请输入："+"          --");
			guesscors = input.next();

			// 6，查找位置 ①区分大小写 ②不区分
			int index = SBuffer.indexOf(guesscors.toUpperCase());
			// 7.根据位置，判断其是否存在 存在移去，不存在反馈
			if (index >= 0) {
				intergral += 10;
				System.out.println("--  "+"此时积分为：" + intergral+"--");
				SBuffer.delete(index,index+guesscors.length());
			} else {
				intergral -= 10;
				System.out.println("--   输入字符不存在    --");
				System.out.println("--   "+"此时积分为：" + intergral+" --");
			}
		}
		System.out.println("----Game Over----");

	}

}
