package demo;

public class Main {
	public static void main(String[] args) {
		Builder studentBuilder = new StudentBuilder()
				.setId(1)
				.setName("Student A")
				.setAge(20);
		
		System.out.println(studentBuilder.build().toString());
		
	}
}
