package xinxin.ataixuexi;

public class Tesk2 {

	public static void main(String[] args) {
		Animalgo dog=new Animalgo();
		dog.setName("����");
		dog.setLegs(4);
		dog.info();

	}


}

 class Animalgo{
    String name;
	static int legs;
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getLegs() {
		return legs;
	}
	public void setLegs(int legs) {
		if(legs>0 && legs%2==0) {
			this.legs = legs;
		}else {
			System.out.println("�������");
		}
	}
	public void info() {
		System.out.println("���֣�"+name+",����"+legs);
	}
}
