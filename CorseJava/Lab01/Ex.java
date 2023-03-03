import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;
public class Ex {
    public static void main(String[] args) {
        System.out.println("Я");
        System.out.println("хорошо");
        System.out.println("знаю");
        System.out.println("Java"); //1 задание

        double x1 = (46 + 10) * (10 / 3.0); //2 задание
        int x2 = (29) * (4) * (-15);
        System.out.println(x1);
        System.out.println(x2);

        int number = 10500; // 3 задание
        double result = ((double)number / 10) / 10;
        System.out.println(result);


        result = (float) (3.6 * 4.1 * 5.9); //4 задание
        System.out.println("4) " + result);


        Scanner scan = new Scanner(System.in); //5 задание
        int a = scan.nextInt();
        int b = scan.nextInt();
        int c = scan.nextInt();
        System.out.println(a);
        System.out.println(b);
        System.out.println(c);


        if (b % 2 !=0) {
            System.out.println("Нечетное");
        } else if (b > 100) {
            System.out.println("Выход за пределы диапозона");
        } else {
            System.out.println("Чётное"); //6 задание
        }

    }

}
