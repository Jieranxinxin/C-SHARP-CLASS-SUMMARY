package xinxin.atxuexi;

public class Round {
	static final float PI=3.14f;//定义静态常量PI,一定要在3.14后加f否则默认double
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
		
		System.out.println("圆的面积为： "+a1.getArea()+"\n"+"圆的边长为： "+a1.getCircumference(2));
	}
}
