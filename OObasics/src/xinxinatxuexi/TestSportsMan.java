package xinxinatxuexi;
/*
 * static����̬�ģ����������������ԡ�������������飩��ʼ���顢�ڲ��࣬�������ι�����
 * 
 * �������ԣ��������������ʵ�����ض����أ����Ҷ�һ�ݣ�����ͨ����ֱ�ӵ��ã�ʵ������ȴ����
 * ������ļ������ڶ���
 * ��������ھ�̬����
 * 
 * ���η������෽������
 * 1.������ļ��ض����أ����ڴ��ж�һ��
 * 2.ֱ�ӿ���ͨ��  ��.�෽��  �ķ�ʽ����    ��ͨ�ķ���ֻ��ͨ������. ��
 * 3.��̬�����ڲ����Ե��þ�̬�ķ��������ԣ������ܵ��÷Ǿ�̬��
 * 4.��̬������ �ڴ��г����磬ͬʱ��������ҲҪ���������ڳ�
 * 
 * ע����̬�����ﲻ������  this\super�ؼ���
 */
public class TestSportsMan {
	public static void main(String[] args) {
		SportsMan s1=new SportsMan("xinxin",12);
		SportsMan s2=new SportsMan("wang",21);
		
		s1.nation="China";
		
		
		System.out.println(s1);
		System.out.println(s2);

		//SportsMan.show()
		s1.show1();

	}

}
//����Դ�룬�����ֶι�����
class SportsMan {
	//ʵ�����������ڶ�����Ǹ������Ŷ���Ĵ�����������
	String name;
	int age;
	//�����
	static String nation;
	public SportsMan(String name, int age) {
		super();
		this.name = name;
		this.age = age;
		SportsMan.show2();
		
	}
	@Override
	public String toString() {
		return "SportsMan [name=" + name + ", age=" + age + ", nation=" + nation + "]";
	}
	
	public void show1() {
		System.out.println("����һ����ͨ�������й����˶�Ա");
	}
	public static void show2() {
		System.out.println("����һ�������������й����˶�Ա");
		show3();
	}
	public static void show3() {
		System.out.println("���Ǿ�̬����");
	}
}