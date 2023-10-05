public class Student {
    private String name;
    private String surname;

    Student(String name, String surname) {
        this.name = name;
        this.surname = surname;
    }
    public void printStudent(){
        System.out.println(name + " " + surname);
    }
}
