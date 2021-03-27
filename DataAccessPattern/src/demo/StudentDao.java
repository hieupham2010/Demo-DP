package demo;

import java.util.ArrayList;
import java.util.List;

public class StudentDao implements Dao<Student> {
	
	private List<Student> students = new ArrayList<Student>();
	
	
	
	@Override
	public List<Student> getAll() {
		
		return students;
	}

	@Override
	public Student getById(int id) {
		for(int i = 0 ; i < students.size() ; i++) {
			if(students.get(i).getId() == id) {
				return students.get(i);
			}
		}
		return null;
	}

	@Override
	public void create(Student student) {
		students.add(student);
	}
	@Override
	public void update(Student student) {
		for(int i = 0 ;i < students.size() ; i++) {
			if(students.get(i).getId() == student.getId()) {
				students.get(i).setName(student.getName());
				students.get(i).setAge(student.getAge());
				break;
			}
		}
	}

	@Override
	public void delete(Student student) {
		students.remove(student);
	}

	
	 
}
