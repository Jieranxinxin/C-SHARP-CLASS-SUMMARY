package banking;

import java.util.Scanner;

public class TestBanking {
	public static void main(String[] args) {
		
		Scanner x = new Scanner(System.in);
		System.out.println("输入0结束!其他任意数字进行操作");
		//System.out.println("存钱输入1,取钱请输入2");
		int y = x.nextInt();
		System.out.println("执行操作！");
		Account a = new Account(500);
		try {
		//ouabcter:
		while (y != 0) {
			
			//System.out.println("存钱输入1,取钱请输入2");
			
			System.out.println("存钱输入1,取钱请输入2,输入0结束!");

			int w = x.nextInt();
			if (w == 2) {
				System.out.println("请输入您所取金额：");
				double i = x.nextInt();
				// System.out.println(i);
				a.withdraw(i);
				//continue;
			} else if (w == 1) {
				System.out.println("请输入您所存金额：");
				double j = x.nextInt();
				a.deposit(j);
				//continue;
			} else if(w==0){
				break;
			}else {
				System.out.println("输入数据不存在！无法进行反馈！请重新输入：");
			}
		}
		}catch(Exception e){
			System.out.println("输入数据类型有误！");	
		}
	}
}
