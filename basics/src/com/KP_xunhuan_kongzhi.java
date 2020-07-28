package com;

/*do...while至少会执行一次
 * 静态方法易被调用 
 */


public class KP_xunhuan_kongzhi {
	
/*	
 * 第一种：有返回值
	public static int find35() {
		
		for(int h=1;h<50;h++) {
			if(h==35) {
				return h;
			}
		}
		return -1;
	}

	*/
	
	
	/*
	 * 第二种，无返回值
	 */
	
	
	public static void find35() {
		
		for(int h=1;h<50;h++) {
			if(h==35) {
				//35的值没等运行，就被停掉
				//return作用1.返回值  2.停掉方法
				return ;
			}
			System.out.println(h);
		}
	}
	
	
	
	public static void main(String[] args) {
		
		System.out.print("******");

		//  第一种，有返回值的情况
		//System.out.print(find35());
		//->35
		
		//第二种，无返回值的情况
		find35();
		
		
		System.out.print("******");

		
		
		
		int j=1;
		for(System.out.println('a');j<4;System.out.println('b'),j++) {
			System.out.println("hello");
			
		}
		//题目  100以内，偶数的个数和偶数的和
		int sum=0;
		int count=0;
		for(int i=1;i<101;i++) {
			if(i%2==0) {
				System.out.println(i);
				sum+=i;
				count++;
			}
			
		}
		System.out.println(" 100以内，偶数的个数是："+count);
		System.out.println(" 100以内，偶数的和是："+sum);
		
		int a=2;
		while(a<101) {
			System.out.println(a);
			a+=2;
		}
	}

}
