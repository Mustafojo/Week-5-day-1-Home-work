using System.Net.NetworkInformation;

class Circle{
    double radius;
    double PI = 3.14159;
    public Circle(){}
    public Circle(double radius){
        this.radius = radius;
    }
    public void SetRadius(double radius){
        this.radius = radius;
    }
    public double GetRadius(){
        return radius;
    }
    public string GetArea(){
        return $"{PI * radius * radius}";
    }
    public string GetDiameter() {
        return $"{radius * 2}";
    }
    public string GetCircumference(){
        return $"{2 * PI * radius}";
    }
}