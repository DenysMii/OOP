import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int rows = 0;
        while(true){
            System.out.print("Введіть кількість полів в таблиці: ");
            try{
                rows  = scanner.nextInt();
            }catch(Exception e){
                scanner.nextLine();
                continue;
            }
            break;
        }

        Worker workers[] = new Worker[rows];
        for(int i = 0; i < rows; i++){
            while(true){
                System.out.println("Введіть дані працівника №" + (i+1) +
                        " (Прізвище, Зарплата (грн), Утримано (грн)):");
                try{
                    workers[i] = new Worker(scanner.next(), scanner.nextInt(), scanner.nextInt());
                }catch(Exception e){
                    scanner.nextLine();
                    continue;
                }
                break;

            }

        }
        int sum[] = new int[3];
        String leftAlignFormat = "|    |     Разом:     | %-10d | %-10d | %-10d | %n";
        String upperBorder = "+----+----------------+------------+------------+------------+%n";
        System.out.format(upperBorder);
        System.out.format("| №  |    Прізвище    |  Зарплата  |  Утримано  |   Видано   |%n");
        System.out.format(upperBorder);
        for(int i = 0; i < rows; i++){
            sum[0] += workers[i].salary;
            sum[1] += workers[i].held;
            sum[2] += workers[i].given;
            workers[i].outputColumns(i+1);
        }

        System.out.format(upperBorder);
        System.out.format(leftAlignFormat, sum[0], sum[1], sum[2]);
        System.out.format(upperBorder);
    }
}