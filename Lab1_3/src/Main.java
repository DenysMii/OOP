import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        System.out.print("Введіть кількість значень в таблиці: ");
        Scanner scanner = new Scanner(System.in);
        int rows = scanner.nextInt();
        Table table = new Table(rows);
        table.inputTemperatures();
        table.calculateTemperatures();
        Table.outputTable();
    }
}