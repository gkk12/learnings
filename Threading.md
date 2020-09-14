A thread is an independent execution path, able to run simultaneously with other threads.

     Main Thread:
A C# program starts in a single thread created automatically by the CLR and operating system (the “main” thread), and is made multithreaded by creating additional threads. 
In a new .NET Core application, the CLR creates a single foreground thread to execute application code via the Main method. This thread is called primary or main thread

A thread is an independent execution path, able to run simultaneously with other threads.

     Main Thread:
A C# program starts in a single thread created automatically by the CLR and operating system (the “main” thread), and is made multithreaded by creating additional threads. 
In a new .NET Core application, the CLR creates a single foreground thread to execute application code via the Main method. This thread is called primary or main thread

A Thread class is responsible for creating and managing a thread in multi-thread programming. It provides a property known as CurrentThread to check the current running thread. 
CurrentThread property is used to retrieve a reference to the currently executing thread from the code that the thread is executing. 
https://dotnetfiddle.net/kfVXxe
When a managed thread is created, the method that executes on the thread is represented by a ThreadStart delegate is passed to the Thread constructor. The thread does not
begin executing until the Thread.Start method is called. 

A thread is analogous to the operating system process in which your application runs. Just as processes run in parallel on a computer, threads run in parallel within a single 
process. Processes are fully isolated from each other; 
threads have just a limited degree of isolation. In particular, threads share (heap) memory with other threads running in the same application. This, in part, is why threading 
is useful: one thread can fetch data in the background, for instance, while another thread can display the data as it arrives.

Foreground vs Background:
The difference is that foreground threads keep an application alive as long as they are running, while background threads do not. In other words, when you close applications,
all background threads are automatically terminated. So, when all the foreground threads complete execution, the application can exit before the background threads return. 
After all the foreground threads have been stopped, or after the application exits, the system stops all background threads.

Critical Section:
In concurrent programming, concurrent accesses to shared resources can lead to errors, so parts of the program where the shared resource is accessed need to be protected 
in ways that avoid the concurrent access. 

Lock:
C# Lock keyword ensures that one thread is executing a piece of code at one time. The lock keyword ensures that one thread does not enter a critical section of code 
while another thread is in that critical section.
The lock keyword calls Enter at the start of the block and Exit at the end of the block. lock keyword actually handles Monitor class at back end.
In the above code, first when the thread enters the deposit method, it will lock transationlock. When another thread tries to enter withdraw, it will also try to lock , 
which is already locked by the first thread. Second thread will have to wait for the first thread to release transactionlock. When the first thread leaves, then another 
thread will lock transactionlock and will enter the critical section.

Why objects:
.Net environment uses some optimizations, and sometimes if a memory location is accessed frequently, data is moved into CPU registers. When this happens, a thread 
willing to read may get a wrong value. Thus using the object ensures, all accesses to this variable is done at the memory location, not at the registers. 
Lock provides other features such as pulse/wait. 
Monitor.Enter and Monitor.Exit are normal .NET methods that accept any variable of type object. The C# language allows for automatic "boxing" (i.e. wrapping) of value 
types (such as integers, booleans, or structs) into reference types of type object, which is what allows us to pass in value types into many .NET methods. Automatic 
boxing however creates a new object each time boxing is necessary, so the object is different for each invocation of the Monitor methods. So, when Monitor.Exit attempts 
to find the lock for the box object, it may find none or a wrong one.










