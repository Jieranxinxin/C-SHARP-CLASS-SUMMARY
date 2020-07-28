package xinxin.atxuexi;

//构造器里面的值固定
public class Gouzaoqi {
	String eat;
	int age;
	public Gouzaoqi() {
		eat="用嘴吃";
		age=18;
	}
public static void main(String[] args) {
	Gouzaoqi a1=new Gouzaoqi();
	System.out.println(a1.age+a1.eat);
}
}
