package comatxinxin0;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

public class Testshiyan {
	public static void main(String[] args) {
		File file1 = new File("C:\\Users\\��Ȼ\\Pictures\\Saved Pictures\\1.jpg");
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
				fo.write(b);     //�����ֶ�����
			}
		} catch (FileNotFoundException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		} catch (IOException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		} finally {
			if (fi != null) {
				try {
					fi.close();
				} catch (IOException e) {
					// TODO �Զ����ɵ� catch ��
					e.printStackTrace();
				}
			}
			if (fo != null) {
				try {
					fo.close();
				} catch (IOException e) {
					// TODO �Զ����ɵ� catch ��
					e.printStackTrace();
				}
			}

		}
	}
}
