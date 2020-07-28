package xinxin.atjavabean;
/*
 * javaBean是指符合以下条件的Java类
 * 类是公共的
 * 有一个无参的公共的构造器
 * 有属性，且有对应的get、set方法
 * 
 * 每   .  一次，表示一层文件目录
 * 包名要小写
 * 
 * import:
 * 1>显示导入指定包下的类或接口
 * 2>写在包的声明和源文件之间
 * 3>如果需要引入多个类或接口，那么并列写出
 * 4>如果导入的是java.lang包下的  如 System String math等，就不需要显示声明
 * 5>
 * import java.util.*;
 * 如何处理同名类的导入  加上类的来源
 * 6> 
 * import static 表示导入指定类的static 的属性和方法
 * 7>
 * 导入java.lang.*只能导入lang包下的所有类或者接口，不能导入lang的子包下的类或接口
 */

import static java.lang.System.out;;
public class Test_javabean {

	public static void main(String[] args) {

		out.println("ss");
	}
}
