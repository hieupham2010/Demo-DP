package demo;

public interface Builder {
	
	public Builder setId(int id);
	public Builder setName(String name);
	public Builder setAge(int age);
	public Student build();
}
