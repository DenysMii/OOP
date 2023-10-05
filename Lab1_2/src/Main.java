import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        System.out.print("Введіть число: ");
        Scanner scanner = new Scanner(System.in);

        double a = scanner.nextDouble();
        System.out.print(MathFunc.lg(a));
    }
}