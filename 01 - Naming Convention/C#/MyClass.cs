// C# variables name should be camelCase.
var myVariable = 30;

// C# namespaces name should be PascalCase.
namespace MyNameSpace
{
    // C# Enumerations name should be PascalCase.
    public enum Colors
    {
        Blue,
        White,
        Red
    }
    
    // C# Classes name should be PascalCase.
    public class MyClass : IMyClass
    {
        // C# public or private constants name should be PascalCase.
        public const string MyConst = "Public or Private Constant";

        // C# private and read-only fields name should be camelcase. (with a _ at the start)
        private readonly string _myPrivateReadonlyField = "Private and Readonly field";

        // C# public fields name should be PascalCase.
        public string MyPublicField = "Public Field";
        
        // C# private fields name should be camelCase.
        private string myPrivateField = "Private Field";

        // C# properties name should be PascalCase.
        public int MyProperty { get; set; }

        // C# methods name should be PascalCase and input arguments name should be camelCase.
        public void MyMethod(string myArgument, string hi) 
        {
            // C# local variables name should be camelCase.
            var myLocalVariable = "Local Variable.";
        }
    }
}