package com;

/*do...while���ٻ�ִ��һ��
 * ��̬�����ױ����� 
 */


public class KP_xunhuan_kongzhi {
	
/*	
 * ��һ�֣��з���ֵ
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
	 * �ڶ��֣��޷���ֵ
	 */
	
	
	public static void find35() {
		
		for(int h=1;h<50;h++) {
			if(h==35) {
				//35��ֵû�����У��ͱ�ͣ��
				//return����1.����ֵ  2.ͣ������
				return ;
			}
			System.out.println(h);
		}
	}
	
	
	
	public static void main(String[] args) {
		
		System.out.print("******");

		//  ��һ�֣��з���ֵ�����
		//System.out.print(find35());
		//->35
		
		//�ڶ��֣��޷���ֵ�����
		find35();
		
		
		System.out.print("******");

		
		
		
		int j=1;
		for(System.out.println('a');j<4;System.out.println('b'),j++) {
			System.out.println("hello");
			
		}
		//��Ŀ  100���ڣ�ż���ĸ�����ż���ĺ�
		int sum=0;
		int count=0;
		for(int i=1;i<101;i++) {
			if(i%2==0) {
				System.out.println(i);
				sum+=i;
				count++;
			}
			
		}
		System.out.println(" 100���ڣ�ż���ĸ����ǣ�"+count);
		System.out.println(" 100���ڣ�ż���ĺ��ǣ�"+sum);
		
		int a=2;
		while(a<101) {
			System.out.println(a);
			a+=2;
		}
	}

}
