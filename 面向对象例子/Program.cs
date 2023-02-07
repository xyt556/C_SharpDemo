
class A
{
    public string s;//公有成员
    private double d;//私有成员
    public void f1()
    {
        s = "Xi Yantao";
        d = 100.01;  //正确，允许访问私有成员
    }
    //static void Main(string[] args)
    //{
    //    A x = new A();//创建实例x
    //    x.f1();//正确，允许访问A类的公有成员方法
    //    x.s = "欢迎你！";//正确，允许访问A类的公有字段
    //    x.d = 120.22;//错误，不能访问A类的私用成员
    //}
}
class Pro
{
    static void Main(string[] args)
    {
        A x = new A();//创建实例x
        x.f1();//正确，允许访问A类的公有成员方法
        x.s = "欢迎你！";//正确，允许访问A类的公有字段
        x.d = 120.22;//错误，不能访问A类的私用成员
    }
}