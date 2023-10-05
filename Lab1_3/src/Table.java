import java.util.Scanner;

import static java.lang.Math.round;

public class Table {
    static int numberOfRows;
    static int[][] tableOfTemperatures;
    Table(int numberOfRows){
        this.numberOfRows = numberOfRows;
    }
    void inputTemperatures(){
        tableOfTemperatures = new int[numberOfRows][2];
        for(int i = 0; i < numberOfRows; i++) {
            System.out.print("Введіть температуру (в F°): ");
            Scanner sc = new Scanner(System.in);
            tableOfTemperatures[i][0] = sc.nextInt();
        }
    }
    void calculateTemperatures(){
        for(int i = 0; i < numberOfRows; i++) {
            tableOfTemperatures[i][1] = (int) round((tableOfTemperatures[i][0] - 32) / 1.8);
        }
    }
    static void outputTable(){
        String leftAlignFormat = "| %-8s | %-8s |%n";
        System.out.format("+----------+----------+%n");
        System.out.format("|    F°    |    C°    |%n");
        System.out.format("+----------+----------+%n");
        for(int i = 0; i < numberOfRows; i++){
            String a = String.valueOf(tableOfTemperatures[i][0]);
            String b = String.valueOf(tableOfTemperatures[i][1]);
            System.out.format(leftAlignFormat, a, b);
        }
        System.out.format("+----------+----------+%n");
    }
}
