// 与有些语言不同，C# 不提供复制构造函数。如果创建了新的对象并希望从现有对象复制值，必须自行编写适当的方法。
class Customer
{
    private string name;
    private int age;
    // 拷贝构造函数.
    public Customer(Customer Person)
    {
        name = Person.name; age = Person.age;
    }
    public Customer(string name, int age)
    {
        this.name = name; this.age = age;
    }
    public void Display()
    {
        Console.WriteLine("{0} is {1}", name, age);
    }
}
class TestPerson
{
    static void Main()
    {
        Customer p1 = new Customer("张三", 40);
        Customer p2 = new Customer(p1);
        p1.Display();
        p2.Display();
    }
}