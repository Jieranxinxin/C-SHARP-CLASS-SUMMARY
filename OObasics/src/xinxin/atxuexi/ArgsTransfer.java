package xinxin.atxuexi;
/*
 * �����Ĳ�������   �ص㡢�ѵ�
 * 1.�βΣ���������ʱ������С�����ڵĲ���
 *   ʵ�Σ����÷���ʱ��ʵ�ʴ���Ĳ�����ֵ
 *   ��ʵ�δ����β�
 * 2.���ɣ�java�еĲ������ݻ��ƣ�ֵ���ݻ���
 *   1���β��ǻ����������͵�  ��ʵ�ε�ֵ���ݸ��βεĻ����������͵ı���
 *   2���β��������������͵�  ��ʵ�ε��������ͱ�����ֵ����Ӧ�Ķѿռ�Ķ���ʵ����׵�ֵַ�����ݸ��βε��������ͱ���
 *   
 *
 */
public class ArgsTransfer {

	public static void main(String[] args) {
		
		ArgsTransfer a1=new ArgsTransfer();
		
		
		int i=10;
		int j=5;
		System.out.println("i:"+i+"j:"+j);
		
		/*
		 * ����
		int temp=i;
		i=j;
		j=temp;
		*/
		a1.swap(i, j);
		//��Ч����  ִ���귽��֮��i,j��ʧ��ֵ����
		System.out.println("i:"+i+"j:"+j);
		
		ArgsTransfer t2=new ArgsTransfer();
		DataSwap ds =new DataSwap();
		System.out.println("ds.m:"+ds.m+"ds.n:"+ds.n);
		
		t2.swap1(ds);
		System.out.println("ds.m:"+ds.m+"ds.n:"+ds.n);
		System.out.println(ds);

		
		
		
	}
	//����Ԫ�ص�ֵ,  �����࣬����һ����������
	public void swap1(DataSwap d) {
		int temp=d.m;
		d.m=d.n;
		d.n=temp;
		System.out.println(d);
		
	}
		
	//����һ����������������������ֵ
	public void swap(int i,int j) {
		int temp =i;
		i=j;
		j=temp;
	}	
}

class DataSwap{
	int m=2;
	int n=3;
}
