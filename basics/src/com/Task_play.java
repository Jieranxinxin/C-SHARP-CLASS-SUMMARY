package com;

import java.util.Random;
import java.util.Scanner;

public class Task_play {
	public static void main(String[] args) {
		
		//开始前的提示
		
		System.out.println("-----------猜数字游戏-----------"+"\n"+
		"-----Dear,现在要开始游戏了哦 ！-----");
		System.out.println("-----如果中途想要退出,请输入: 0-----");
		System.out.println();

		//输入随机数范围
		
		int randNum;
		System.out.print("请输入开始范围：");
    	Scanner input=new Scanner(System.in);
    	int START=input.nextInt();
    	System.out.print("请输入结束范围：");
    	int END=input.nextInt();
        Random random = new Random();    //创建Random类对象          
        randNum = random.nextInt(END - START + 1) + START;   //产生随机数
         
   
        
        System.out.println("请在"+START+"~"+END+"范围内输入你猜的数:");
        while(true) {
        int guessNum=input.nextInt();
        if(guessNum!=0) {
        	//新想法：猜打了之后，范围缩小
        	if(guessNum>randNum) {
        		System.out.print("猜大了哦！\n");
        		System.out.println("请在"+START+"~"+guessNum+"范围内输入你猜的数:");
        		continue;
        	}else if(guessNum<randNum) {
        		System.out.print("猜小了哦！\n");
        		System.out.println("请在"+guessNum+"~"+END+"范围内输入你猜的数:");
        		continue;
        	}
        	/*else if(guessNum>END||guessNum<START) {
        		System.out.println("您输入的数据不在范围内，请重新输入");
        		continue;
        	}*/
        	else {
        		System.out.print("WOW!猜对了！");
        		break;
        	}
        }else {
        	System.out.println("---------- 游戏结束！ -----------");
        	break;
        }
		
	}
	}
}
