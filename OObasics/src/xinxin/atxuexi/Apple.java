package xinxin.atxuexi;

public class Apple {

	String color ="Red";
	static int count=120;//��̬��Ա��������
	final boolean MATRUE=true;
	
	int num;
	float price;
	
	public Apple () {
		num=10;
		price=5.2f;
	}
	
	public static void main(String[] args) {
		System.out.println(Apple.count);//��̬��������ͨ������ֱ�ӷ���
		Apple apple = new Apple();//����һ��Apple����
		System.out.println(apple.color);
		System.out.println(apple.MATRUE);
		
		Apple apple1=new Apple();
		System.out.println("ƻ���������� "+apple.num+"\n"+"ƻ���ļ۸�"+apple.price);

		
	}
	
}
