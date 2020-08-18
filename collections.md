Generic Collections: These collections hold elements of same datatypes.  
Non Generic Collections: They hold elements of different datatypes.

## Delegates:
A delegate is an object which refers to a method or you can say it is a reference type variable that can hold a reference to the methods.
For example, if you click an Button on a form (Windows Form application), the program would call a specific method. In simple words, 
it is a type that represents references to methods with a particular parameter list and return type and then calls the method in a program 
for execution when it is needed.

Advantages of using Delegates:  
- Provides a good way to encapsulate the methods.


## Dictionary:  
- It is a generic collection which is generally used to store key/value pairs.
- It is dynamic in nature means the size of the dictionary is grows according to the need.
- In Dictionary, you can only store same types of elements.
 
Syntax:  
 Dictionary<int, string> My_dict1 = new Dictionary<int, string>();  
 My_dict1.Add(10, "Welcome");  
 My_dict1.Add(11, "Gautham");    
          foreach(KeyValuePair<int, string> ele1 in My_dict1) 
          { 
              Console.WriteLine("{0} and {1}", 
                        ele1.Key, ele1.Value); 
          } 
          Console.WriteLine(); 

 Removing the elements from the dictionary:  
 My_dict.Remove(1123);  

 Searching through a value or a key:  
 - ContainsKey: This method is used to check whether the Dictionary<TKey,TValue> contains the specified key.
	- ContainsValue: This method is used to check whether the Dictionary<TKey,TValue> contains a specific value.  
 
          if (My_dict.ContainsKey(10)==true) 
          { 
              Console.WriteLine("Key is found...!!"); 
          } 
  
          else
          { 
               Console.WriteLine("Key is not found...!!"); 
          } 
            
          // Using ContainsValue() method to check 
          // the specified value is present or not  
          if (My_dict.ContainsValue("Gautham")==true) 
          { 
              Console.WriteLine("Value is found...!!"); 
          } 
  
          else
          { 
               Console.WriteLine("Value is not found...!!"); 
          } 
          
## Arrays:  
- They are generic in nature.
- An array is a group of like-typed variables that are referred to by a common name.
- Arrays are objects in C#. 
- This has fixed size and can’t increase or decrease dynamically

### Different types of arrays:  
- One Dimensional Array
- Multidimensional Arrays
- Jagged Arrays: An array of arrays

## Array List:  
- They are non generic.
- One can store elements of the same type and of the different types.
- Arraylist can accept null as a valid value.
- The ArrayList class implements the IEnumerable, ICollection, IList, and ICloneable interfaces.
- The ArrayList class inherits the Object class.

## List:
- They are generic.
