public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize in the property declaration

    public MyClass() 
    {
        MyProperty = 10; // Initialize in the constructor
    }

    public void MyMethod() {
        Console.WriteLine(MyProperty); // Now you are guaranteed the property has a value
    }
}