import java.util.Scanner;
public class Worker {
    private String surname;
    int salary;
    int held;
    int given;
    Worker(String surname, int salary, int held){
        this.surname  = surname;
        this.salary = salary;
        this.held = held;
        given = salary - held;
    }

    void outputColumns(int k){
        String leftAlignFormat = "| %-2d | %-14s | %-10d | %-10d | %-10d | %n";
        System.out.format(leftAlignFormat, k, surname, salary, held, given);
    }


}
