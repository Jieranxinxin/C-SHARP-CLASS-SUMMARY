package xinxin.atxuexi;
/*
 * һ��������������һ����װ������
 * ���ٵ����⣺����������Ķ����Ժ����ֱ��ͨ��������.���ԡ��ķ�ʽ�����Ӧ�Ķ������Ը�ֵ�Ļ���
 * ���ܻ���ֲ�����ʵ����������⣬���ǿ��ǲ��ö�����ֱ���������ԣ�����ͨ�������󡣷���������ʽ��
 * �����ƶ�������Եķ��ʣ�ʵ������У������Ե�Ҫ��Ϳ���ͨ��������ʵ��
 * 
 * �������������װ�Ե�˼�룩���������˽�л����ṩ�����ķ�����setter&getter����ʵ�ֵ���
 * 
 * ����Ȩ�����η�   �����ࡢ���ԡ�����
 * public   
 * private ���ε�����ֻ���ڱ����е��ã����˴��಻�ɵ���
 * ȱʡ   ɶ��û��   ���ڲ� ͬһ���� 1
 * protected  ���ڲ� ͬһ���� ����
 * 
 * �������Ȩ���У�public ȱʡ
 * 
 * ע��Ȩ�޴Ӵ�С��public protated ȱʡdefault   private
 */
public class Tesk_Animal {
	public static void main(String[] args) {
		Animal_1 a1=new Animal_1();
		a1.name="xinxin";
		System.out.println();

		//a1.legs=3;
		a1.setLegs(4);
		a1.info();
		a1.eat();	
	}

}
class Animal_1 {
	String name;
	int legs;
	
	//����
	public void eat() {
		System.out.println("�����ʳ");
	}
	public void sleep() {
		System.out.println("����˯��");
	}
	public void info() {
		System.out.println("name:"+name+"legs:"+legs);
	}
	
	public void setLegs(int l) {
		if(l>0&&l%2==0) {
			legs=l;
		}else {
			System.out.println("������������");
		}
	}
	public int getLegs() {
		return legs;
	}
	
}