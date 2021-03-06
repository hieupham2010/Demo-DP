package demo;

public class StudentBuilder implements Builder {
	
	private int id;
	private String name;
	private int age;
	
	@Override
	public Builder setId(int id) {
		this.id = id;
		return this;
	}

	@Override
	public Builder setName(String name) {
		this.name = name;
		return this;
	}

	@Override
	public Builder setAge(int age) {
		this.age = age;
		return this;
	}

	@Override
	public Student build() {
		return new Student(id , name , age);
	}
	
}
