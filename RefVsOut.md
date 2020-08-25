Ref vs Out:
Ref and out keywords in C# are used to pass arguments within a method or function. Both indicate that an argument/parameter is passed by reference. By default parameters are passed to a method by value. By using these keywords (ref and out) we can pass a parameter by reference.
Ref: 
1.	public static string GetNextName(ref int id)  
2.	{  
3.	    string returnText = "Next-" + id.ToString();  
4.	    id += 1;  
5.	    return returnText;  
6.	}  
7.	static void Main(string[] args)  
8.	{  
9.	    int i = 1;  
10.	    Console.WriteLine("Previous value of integer i:" + i.ToString());  
11.	    string test = GetNextName(ref i);  
12.	    Console.WriteLine("Current value of integer i:" + i.ToString());  
13.	}  

Out:
1.	public static string GetNextNameByOut(out int id)  
2.	{  
3.	    id = 1;  
4.	    string returnText = "Next-" + id.ToString();  
5.	    return returnText;   
6.	}  
7.	static void Main(string[] args)  
8.	{  
9.	    int i = 0;  
10.	    Console.WriteLine("Previous value of integer i:" + i.ToString());  
11.	    string test = GetNextNameByOut(out i);  
12.	    Console.WriteLine("Current value of integer i:" + i.ToString());  
13.	}  
Ref
The parameter or argument must be initialized first before it is passed to ref.	
It is not required to assign or initialize the value of a parameter (which is passed by ref) before returning to the calling method.	
Passing a parameter value by Ref is useful when the called method is also needed to modify the pass parameter.
It is not compulsory to initialize a parameter value before using it in a calling method.
When we use REF, data can be passed bi-directionally.	
Out
It is not compulsory to initialize a parameter or argument before it is passed to an out.
A called method is required to assign or initialize a value of a parameter (which is passed to an out) before returning to the calling method.
Declaring a parameter to an out method is useful when multiple values need to be returned from a function or method.
A parameter value must be initialized within the calling method before its use.
When we use OUT data is passed only in a unidirectional way (from the called method to the caller method).

Both ref and out are treated differently at run time and they are treated the same at compile time.
Properties are not variables, therefore it cannot be passed as an out or ref parameter.
 
So ref is basically bi directional; 
it can take value from caller function and apply operation on this variable inside the calling function and revert back to the caller function with updated value  -- you can see the difference in given screen shots.

Unidirectional out: 
I created a new function functionWithout with ‘out Num’ parameter then called this function from caller function. I assigned 10 to Num and passed it into functionWithout then debugged application, the value we passed inside the function has been discarded by function and we need to re-initialize inside the function with 0 (any value) and add 4 with this value, now the value of Num is 4 and after exiting the calling function, same value still remains in variable of caller function.
https://www.c-sharpcorner.com/blogs/ref-and-out-keywords-in-c-sharp#:~:text=Passing%20parameter%20by%20ref&text=the%20calling%20function.-,Value%20inside%20the%20caller%20function.,difference%20in%20given%20screen%20shots.

Returning multiple value from a function using ref
 
Ref and out both are use for returning multiple values from function. Here I am creating a function calculator that has four parameters, FirstNumber , SecondNumber, ref int Sum and ref int difference. By default this function returns the multiplication of two numbers but we will return sum and difference by ref parameter.

You can see in the given example that the calculator function returns multiplication of two variables but the sum and difference of these two variable are assigned to the variable which are passed with reference.

Thus it clearly seems that this function returns three output multiplications, sum and difference. Out also works like this.

