package comatxinxin0;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

public class Testshiyan {
	public static void main(String[] args) {
		File file1 = new File("C:\\Users\\孑然\\Pictures\\Saved Pictures\\1.jpg");
		File file2 = new File("dog.jpg");

		FileInputStream fi = null;
		FileOutputStream fo = null;

		try {
			fi = new FileInputStream(file1);
			fo = new FileOutputStream(file2);

			byte[] b = new byte[1024];
			int len;
			
			while ((len = fi.read(b)) != -1) {
				// fo.write(b, 0, len);
				fo.write(b);     //这两种都可以
			}
		} catch (FileNotFoundException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		} catch (IOException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		} finally {
			if (fi != null) {
				try {
					fi.close();
				} catch (IOException e) {
					// TODO 自动生成的 catch 块
					e.printStackTrace();
				}
			}
			if (fo != null) {
				try {
					fo.close();
				} catch (IOException e) {
					// TODO 自动生成的 catch 块
					e.printStackTrace();
				}
			}

		}
	}
}
