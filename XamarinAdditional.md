Xamarin Forms Main Project:

Sharing of the Business logic and UI (User interface) throughout the application happens because of this project.
The first one is the Dependencies folder, which consists of two extra folders (Packages and SDK). 
Dependency enables Xamarin. Forms applications to invoke native platform functionality from shared code.
There are 2 packages namely Xamarin.Essentials and Xamarin.Forms.
Xamarin.Essentials provides developers with cross-platform APIs for their mobile applications. Eg Detect Shake, Battery. 
App.xaml page consist of our Application Resources. Here we can define our Custom resources like Styles, colors and font-family, etc. 
These resources are accessible throughout the application.
App.xaml.cs page, it consists of C# Code. That which we can do through App.xaml we can also do with the App.xaml.cs page.
Page setting, where we can set the Main Page of our application.
Similarly, if we see the Main Page, it consists of two portions one is Mainpage.xaml and other is MainPage.xaml.cs, these are two Page normal pages of presentation view.

MonoTouch:
MonoTouch allows developers to create iOS applications using C# and the .NET framework.
One crucial difference between MonoTouch and Mono is that applications created using the former are compiled down to machine code. Mono is different;
it is a Just-in-time (JIT) compiler. This means that code is only compiled into native code just before it runs. Apple does not allow that kind of execution on the iPhone, 
so MonoTouch apps are “proper” iPhone apps.


Difference between Xamarin Forms and Xamarin Native:
Shared code project: Holds your common code base and also because you are using Xamarin.Forms you can write code for your UI.

XAML File:
A markup language is a computer language that uses tags to define elements within a document.
XAML is a markup language which is used to create visible UI elements, and then separate the UI definition from the run-time logic by using code-behind files that are 
joined to the markup through partial class definitions.



