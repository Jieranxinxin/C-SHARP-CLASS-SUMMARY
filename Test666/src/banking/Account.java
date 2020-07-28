package banking;

public class Account {
	private double balance;// 当前余额

	public Account(double init_balance) {// 公有构造器，初始化当前余额
		balance=init_balance;
		//System.out.println("当前余额为：" + balance);
	}

	public double getBalance() { // 获取账户余额
		return balance;
	}

	public void deposit(double amt) { // 存钱
		balance += amt;
		System.out.println("您所存的金额为：" + amt);
		System.out.println("存入后总余额为：" + balance);
	}

	public void withdraw(double amt) { // 取钱
		if (amt > balance) {
			System.out.println("金额不足！请存入足够金额后再取，谢谢！");
		} else {
			balance -= amt;
			System.out.println("您所取的金额为：" + amt);
			System.out.println("取出后总余额为：" + balance);
		}
	}

}
