package com.xinxin3;
/*
 * ģ�巽�����ģʽ
 */
public class TestTemplate {
public static void main(String[] args) {
	new SubTemplate().spendTime();
}
}
abstract class Template{
	//���󷽷�,��ȷ���Ĵ�����ɳ����
	public abstract void code();
	//ʵ�巽��
	//��ȷ���ı�¶��ȥ
	public void spendTime() {
		//���㵱ǰʱ��
		long start=System.currentTimeMillis();
		
		//���ⷽ������
		this.code();
		
		long end =System.currentTimeMillis();
		System.out.println("ִ�����code���������ѵ�ʱ��"+(end-start));
		
	}
}
class SubTemplate extends Template{
	public void code() {
		boolean flag=false;
		for(int i=2;i<=10000;i++) {
			//Math.sqrt(i)��i����
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