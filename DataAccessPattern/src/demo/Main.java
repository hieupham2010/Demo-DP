package demo;

public class Main {
	public static void main(String[] args) {
		
		Student s1 = new Student(1 , "Student A" , 20);
		Student s2 = new Student(2 , "Student B" , 20);
		Student s3 = new Student(3 , "Student C" , 20);
		StudentDao studentDao = new StudentDao();
		studentDao.create(s1);
		studentDao.create(s2);
		studentDao.create(s3);
		System.out.println("--------------------------------------------");
		for (Student student : studentDao.getAll()) {
			System.out.println(student.toString());
		}
		studentDao.delete(s1);
		System.out.println("--------------------------------------------");
		for (Student student : studentDao.getAll()) {
			System.out.println(student.toString());
		}
		
		studentDao.update(new Student(2 , "Student E" , 21));
		System.out.println("--------------------------------------------");
		for (Student student : studentDao.getAll()) {
			System.out.println(student.toString());
		}
	}
}
