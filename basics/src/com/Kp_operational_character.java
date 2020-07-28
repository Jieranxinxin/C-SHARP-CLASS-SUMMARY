package com;

public class Kp_operational_character {

	public static void main(String[] args) {
		
		//i=i*0.1  错误，因为得出的不是整型int而是双精度浮点double的0.1
		
		int i=1;
		int j=1;
		i*=0.1;
		System.out.println(i);

		j=(int)(j*0.1);//0.1转化成整型的0
		//等同于
		j*=0.1;//结果默认转化成整型.这里0
		System.out.println(j);
		
		//  %  取余 +- 取决于被模数
		short a=10;
		short b=11;
		//a=a+1;编译不通过
		a=(short)(a+1);//这样写，不划算，a由short->int->short
		b+=1;//即可以实现运算，又不会更改a的数据类型
		System.out.print(a+"\n");
		System.out.print(b);
		
		
		//你怎么辣么阴险，运行结果为：结果为真
		//因为这个是赋值，在开头已经赋过值了
		//若为==，运行结果为：结果为假
		boolean c=false;
		if(c=true) {
			System.out.println("结果为真");
		}
		else
			System.out.println("结果为假");
		
		
		
		//&与&&的区别
		//&不管左右两端是ture还是false，两端都会进行运算
		//&&确定一端，另一端不会进行运算
		//运算时，选  && 防止异常和简洁
		boolean d=false;
		int d1=10;
		if(d & (d1++)>0) {
			System.out.println("GOOD");
		}else {
			System.out.println("OK!");
		}
		System.out.println(d1);

		int d2=10;
		if(d && (d2++)>0) {
			System.out.println("GOOD");
		}else {
			System.out.println("OK!");
		}
		System.out.println(d2);
		
		

		int m =12;
		int n=5;
		double k=(double)m/n;
		double e=m/5.0;

		System.out.println(k);
		System.out.print(e);
		

	}

}
