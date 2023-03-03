package ITMO.JavaCorse.Lab02;

public class Car {
    protected String mark;
    protected String series;
    protected String type;
    protected String wheels;
    protected String color;
    protected String mass;
    public Car(){
        this.mark = "Tesla";
        this.series = "Model S";
        this.type = "Седан";
        this.wheels = "Лето";
        this.color = "Белый";
        this.mass = "1886 кг";
    }
    public Car(String mark,String series, String type, String wheels, String color, String mass){
        this.mark = mark;
        this.series=series;
        this.type=type;
        this.wheels=wheels;
        this.color=color;
        this.mass=mass;
    }
}
