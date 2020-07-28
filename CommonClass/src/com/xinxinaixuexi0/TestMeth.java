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
		
		//只能整除，否则报错
		//System.out.println(bd1.divide(bd2));
		
		//bd1除以bd2按照默认的精度   四舍五入
		System.out.println(bd1.divide(bd2,BigDecimal.ROUND_HALF_UP));
		////bd1除以bd2   15位小数  四舍五入
		System.out.println(bd1.divide(bd2,15,BigDecimal.ROUND_HALF_UP));
	}

}
