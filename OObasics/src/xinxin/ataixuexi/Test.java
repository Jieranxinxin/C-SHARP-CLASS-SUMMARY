package xinxin.ataixuexi;

public class Test {
	public static void main(String[] args) {
		Animal a1=new Animal();
		a1.name="����";
		a1.setLegs(2);
		System.out.println("�������������ǣ�"+a1.name);
		System.out.println("����"+a1.legs+"ֻ��");
		a1.info();
	}	
}

class Animal{
	String name;
	static int legs;

	public void setLegs(int l) {
		if(l>0&&l%2==0) {
			legs=l;
		}else {
			System.out.println("�������ݴ���");
		}
	}
	public int getLegs() {
		return legs;
	}
	
	public void info(){
		System.out.println("Animal [name=" + name + ", legs=" + legs + "]"); 
	}
	
}