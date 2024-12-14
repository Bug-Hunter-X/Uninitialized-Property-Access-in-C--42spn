public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property with a default value

    public void MyMethod()
    {
        int value = MyProperty; // Now the property is initialized, preventing potential issues.
    }
}