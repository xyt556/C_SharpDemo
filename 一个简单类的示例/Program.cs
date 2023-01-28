public class Hello  //声明一个类-Hello
{
    private int x = 1;  // x 为字段名
    public void DisplayMessage()    //声明一个方法
    {
        Console.WriteLine("Hello");
    }
    static void Main(string[] args)
    {
        Hello myHello = new Hello(); //类并不能直接使用，需要根据类来创建对象，也称为类的实例化。通过new关键字，创建了Hello类的一个对象myHello。
        myHello.DisplayMessage(); //调用Hello类中的DisplayMessage方法。
    }
}
