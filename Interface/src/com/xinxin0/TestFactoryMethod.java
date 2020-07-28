package com.xinxin0;
//工厂方法的设计模式
public class TestFactoryMethod {
public static void main(String[] args) {
	IWorkFactory i=new StudentWorkFactory();
	i.getWork().doWork();
	
	IWorkFactory j=new TeacherWorkFactory();
	j.getWork().doWork();
}
}

//没有确定好，要创建哪一个对象
interface IWorkFactory{
	//返回Work对象
	Work getWork();
}
//让他的类去实现接口
class StudentWorkFactory implements IWorkFactory{

	@Override
	public Work getWork() {
		return new StudentWork();
	}
	
}

class TeacherWorkFactory implements IWorkFactory{

	@Override
	public Work getWork() {
		return new TeacherWork();
	}
	
}

interface Work{
	void doWork();
}

class StudentWork implements Work{

	@Override
	public void doWork() {
		// TODO 自动生成的方法存根
		System.out.println("学生写作业");
	}
	
}
class TeacherWork implements Work{

	@Override
	public void doWork() {
		// TODO 自动生成的方法存根
		System.out.println("老师写教案");
	}
	
}