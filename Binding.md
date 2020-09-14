Data binding is used for linking two objects. This is used to reflect changes: If a change in one property occurs than it automatically reflects in the other property.
The main benefit of Data binding is the data is synchronized automatically between views and data source.

public List<string> ListData { get; set; }  
public MainPage()  
        {  
ListData = new List<string>()  
            {  
                "String a",  			
                "String b",  			 
                "String c",  			 
                "String d",  			 
                "String e",  
                "String f",  
            };  
            InitializeComponent();  
}

XAML code:
                <ListView x:Name="list" 
                ItemsSource="{Binding ListData, Source={x:Reference MainPage}}"> 
                </ListView> 


