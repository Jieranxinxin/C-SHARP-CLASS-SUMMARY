package com.xinxin.aixuexin0;
/*
 * 二、如可处理Exception异常
 * Java提供异常处理  抓抛模型
 * 1."抛"
 * >一旦抛出此异常对象，那么程序就会终止执行
 * >此异常类的对象抛给方法的调用者
 * 2."抓"，抓上一步抛出的异常对象
 * 1>处理方式一
 * try{
 *     可能出现异常的代码
 * }catch(Exception1 e1){
 *     处理的方式一
 * }catch(Exception2 e2){
 *     处理的方式二
 * }finally{
 *     一定要执行的
 * }
 * 注：1.try内声明的变量，类似局部变量，出了try()语句，就不可被调用
 *    2.finally是可选的  里面的代码一定会执行
 *    3.catch语句内部是对异常的处理
 *    	>getMessage();//获取错误信息 printStackTrace();//打印出异常的堆栈信息
 *    4.可以有多个catch语句，try中抛出的异常类对象从上往下匹配异常类型
 *    一旦满足就执行catch中代码。执行完跳出
 *    5.如果异常被处理，后面的代码可以执行
 * 三、对于运行时异常来说，可以不显示的进行处理
 *    对于编译时异常来说，必须要显示的进行处理
 */
public class TestException1 {

}
