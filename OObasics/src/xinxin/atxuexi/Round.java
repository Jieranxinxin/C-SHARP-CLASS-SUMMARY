package xinxin.atxuexi;

public class Round {
	static final float PI=3.14f;//���徲̬����PI,һ��Ҫ��3.14���f����Ĭ��double
	int r=1;
	public float getArea() {
		float area=PI*r*r;
		return area;
	}

	public float getCircumference(int a) {
		float cir=2*PI*a;
		return cir;
	}
	
	
	public static void main(String[] args) {
		
		Round a1=new Round();
		
		System.out.println("Բ�����Ϊ�� "+a1.getArea()+"\n"+"Բ�ı߳�Ϊ�� "+a1.getCircumference(2));
	}
}
