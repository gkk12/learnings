A partial class splits the definition of a class over two or more source (.cs) files but it will be compiled as one class when the classes are compiled.
Eg: There is a "Person" table in the database with three fields "Id","Name" and "DateOfBirth" and age of each person has to be shown. If we add a new column 
to the table for age in database for the "Person" table then it fails the normalization rule. If we add a new property to auto-generated code then it will not 
be mapped to the database. So we create a partial class portion in a separate source file that has the "Age" property which calculates the age of the person.
