package xinxin.atxuexi;
/*
 * 方法的参数传递   重点、难点
 * 1.形参：方法声明时，方法小括号内的参数
 *   实参：调用方法时，实际传入的参数的值
 *   从实参传向形参
 * 2.规律：java中的参数传递机制，值传递机制
 *   1）形参是基本数据类型的  将实参的值传递给形参的基本数据类型的变量
 *   2）形参是引用数据类型的  将实参的引用类型变量的值（对应的堆空间的对象实体的首地址值）传递给形参的引用类型变量
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
		 * 交换
		int temp=i;
		i=j;
		j=temp;
		*/
		a1.swap(i, j);
		//无效方法  执行完方法之后，i,j消失，值不变
		System.out.println("i:"+i+"j:"+j);
		
		ArgsTransfer t2=new ArgsTransfer();
		DataSwap ds =new DataSwap();
		System.out.println("ds.m:"+ds.m+"ds.n:"+ds.n);
		
		t2.swap1(ds);
		System.out.println("ds.m:"+ds.m+"ds.n:"+ds.n);
		System.out.println(ds);

		
		
		
	}
	//交换元素的值,  引用类，类是一个引用类型
	public void swap1(DataSwap d) {
		int temp=d.m;
		d.m=d.n;
		d.n=temp;
		System.out.println(d);
		
	}
		
	//定义一个方法，交换两个变量的值
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
