package com.xinxinaixuexi0;

import java.math.BigDecimal;
import java.math.BigInteger;

import org.junit.Test;

public class TestMeth {
	@Test
	public void testBigInteger() {
		BigInteger bi=new BigInteger("123343");
		BigDecimal bd1=new BigDecimal("1233.211");
		BigDecimal bd2=new BigDecimal("11");
		System.out.println(bi);
		
		//ֻ�����������򱨴�
		//System.out.println(bd1.divide(bd2));
		
		//bd1����bd2����Ĭ�ϵľ���   ��������
		System.out.println(bd1.divide(bd2,BigDecimal.ROUND_HALF_UP));
		////bd1����bd2   15λС��  ��������
		System.out.println(bd1.divide(bd2,15,BigDecimal.ROUND_HALF_UP));
	}

}
