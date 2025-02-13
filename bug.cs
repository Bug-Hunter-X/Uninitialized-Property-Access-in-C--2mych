public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property before it is initialized can lead to unexpected behavior
        Console.WriteLine(MyProperty); // This may output 0 or throw an exception, depending on context
    }
}