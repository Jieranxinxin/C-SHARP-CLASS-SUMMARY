package com.xinxin0;
//�������������ģʽ
public class TestFactoryMethod {
public static void main(String[] args) {
	IWorkFactory i=new StudentWorkFactory();
	i.getWork().doWork();
	
	IWorkFactory j=new TeacherWorkFactory();
	j.getWork().doWork();
}
}

//û��ȷ���ã�Ҫ������һ������
interface IWorkFactory{
	//����Work����
	Work getWork();
}
//��������ȥʵ�ֽӿ�
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
		// TODO �Զ����ɵķ������
		System.out.println("ѧ��д��ҵ");
	}
	
}
class TeacherWork implements Work{

	@Override
	public void doWork() {
		// TODO �Զ����ɵķ������
		System.out.println("��ʦд�̰�");
	}
	
}