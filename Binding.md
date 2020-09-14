Data binding is used for linking two objects. This is used to reflect changes: If a change in one property occurs than it automatically reflects in the other property.
The main benefit of Data binding is the data is synchronized automatically between views and data source.

public List<string> ListData { get; set; }  
public MainPage()  
        {  
ListData = new List<string>()  
            {  
                "String a",  			XAML code:
                "String b",  			 <ListView x:Name="list" 
                "String c",  			 ItemsSource="{Binding ListData, Source={x:Reference MainPage}}"> 
                "String d",  			 </ListView> 
                "String e",  
                "String f",  
            };  
            InitializeComponent();  
}
