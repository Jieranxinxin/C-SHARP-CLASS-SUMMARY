package com.xinxin3;
/*
 * 模板方法设计模式
 */
public class TestTemplate {
public static void main(String[] args) {
	new SubTemplate().spendTime();
}
}
abstract class Template{
	//抽象方法,不确定的代码设成抽象的
	public abstract void code();
	//实体方法
	//把确定的暴露出去
	public void spendTime() {
		//计算当前时间
		long start=System.currentTimeMillis();
		
		//虚拟方法调用
		this.code();
		
		long end =System.currentTimeMillis();
		System.out.println("执行这个code方法所花费的时间"+(end-start));
		
	}
}
class SubTemplate extends Template{
	public void code() {
		boolean flag=false;
		for(int i=2;i<=10000;i++) {
			//Math.sqrt(i)对i开方
			for(int j=2;j<=Math.sqrt(i);j++) {
				if(i%j==0) {
					flag=true;
					break;
				}
			}
			if(!flag) {
				System.out.println(i);
			}
			flag=false;
		}
	}
}