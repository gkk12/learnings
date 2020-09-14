iOS:
1.Non-running - The app is not running / terminated by the user.(not available on the screen or background)
2.Inactive - This state occurs while the app transitioning to the Active state or transitioning from the Active state on the foreground. This means the this state occurs 
             only while transitioning from one state to another. These are the app states transitions that transit through the Inactive state,
             Not Running -> Inactive -> Active
             Active -> Inactive -> Background
             Background -> Inactive -> Active
             For example, when a call or SMS message is received.
3.Active - The app is running in the foreground, and receiving events and executing the code.
4.Background - The app is running in the background, and executing code. But in a limited time period the OS automatically moves the app to the Suspended state and stops 
               execution of code. 
5.Suspended - The app is in the background, but no code is being executed.  App remains on the memory but not executing any code. If any running app needs memory and the 
              system is low on memory, the OS will terminate some suspended apps to free the memory.
              
         
Android:
1.onCreate() - Fires when the system first creates the activity. For example, Binding data to lists, declaring the user interface (defined in an XML layout file).
2.onStart() - The onStart() call makes the activity visible to the user, as the app prepares for the activity to enter the foreground and become interactive. For example, 
              this method is where the app initializes the code that maintains the UI.
3.onResume() - This is the state in which the app interacts with the user. The app stays in this state until something happens to take focus away from the app. Such an 
               event might be, for instance, receiving a phone call, the user’s navigating to another activity, or the device screen’s turning off.
4.onPause() – When the user is leaves the activity, it indicates that the activity is no longer in the foreground. For example: A dialog opens. 
5.onStop() - When the activity is no longer visible to the user, it has entered the Stopped state. For example, when a newly launched activity covers the entire screen. 
6.onDestroy() - onDestroy() is called before the activity is destroyed. 

Xamarin:
1.The OnStart method is invoked when the application starts.
2.The OnSleep method is invoked when the application goes to the background.
3.The OnResume method is invoked when the application resumes from the background.


         
         


