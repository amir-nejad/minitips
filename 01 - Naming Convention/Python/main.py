# Python variables name should be snake_case
my_age = 30

# Python methods name and inputs should be snake_case
def my_method(simple_input1, simple_input2, simple_input3):
    pass


# Python classes name should be PascalCase
class MyClass:
    # Python constants should be MACRO_CASE
    MAX_CHAR = 40
    
    def __init__(self, name) -> None:
        self.my_name = name
        pass
    
    # Public method definition (snake_case)
    def check_max_char(self, simple_string):
        if len(simple_string) > 40:
            print(f"The maximum characters allowed is {self.MAX_CHAR}")
        else:
            print("Ok")
        pass
    
    # Protected method definition (snake_case with _ at the first place)
    def _protected_function():
        pass
    
    # Private method definition (snake_case with __ at the first place)
    def __private_function():
        pass

# Python objects name should be snake_case
my_class = MyClass("Amirhossein")