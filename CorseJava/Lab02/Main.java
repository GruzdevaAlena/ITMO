package ITMO.JavaCorse.Lab02;

import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {
        Calculator calc = new Calculator();
        System.out.println(calc.substract(5.2,5));

        Car car1 = new Car();
        Car car2 = new

                Car("BMW","M5","Седан","Зима","Черный","2000 кг");
        System.out.println(car1.mark);
        System.out.println(car2.mark +" "+ car2.series +" "+ car2.color);
    }
}