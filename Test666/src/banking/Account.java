package banking;

public class Account {
	private double balance;// ��ǰ���

	public Account(double init_balance) {// ���й���������ʼ����ǰ���
		balance=init_balance;
		//System.out.println("��ǰ���Ϊ��" + balance);
	}

	public double getBalance() { // ��ȡ�˻����
		return balance;
	}

	public void deposit(double amt) { // ��Ǯ
		balance += amt;
		System.out.println("������Ľ��Ϊ��" + amt);
		System.out.println("����������Ϊ��" + balance);
	}

	public void withdraw(double amt) { // ȡǮ
		if (amt > balance) {
			System.out.println("���㣡������㹻������ȡ��лл��");
		} else {
			balance -= amt;
			System.out.println("����ȡ�Ľ��Ϊ��" + amt);
			System.out.println("ȡ���������Ϊ��" + balance);
		}
	}

}
