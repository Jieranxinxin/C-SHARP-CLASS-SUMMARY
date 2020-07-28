package xinxin.ataixuexi;

public class Test1 {

	public static int add(int m,int n) {
		int rusult =m+n;
		return rusult;
	}
	public int minus(int m,int n) {
		int result=m-n;
		return result;
	}
	
	public static void main(String[] args) {
		
		System.out.println("两数之和为："+add(10,20));
		
		Test1 num1=new Test1();
		System.out.println("两数之差为："+num1.minus(50, 1));
		
	}
}

