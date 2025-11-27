Design Patterns Assignment

This project demonstrates the implementation of three software design patterns: 
Factory, Adapter, and Observer. Only specific parts of the project were modified as instructed. 
The rest of the codebase was left unchanged.

1. Factory Design Pattern

The Factory pattern was implemented in the DatabaseFactory.cs file. 
The purpose of this pattern is to create instances of different database handler classes without exposing the concrete classes to the client code. 
A static CreateDatabase method was added, which accepts a DatabaseType enum and returns the correct implementation of the IDatabase interface. 
This allows the DataAnalyticsEngine class to work with any supported database in a generic manner without knowing which database type is being used.

2. Adapter Design Pattern

The Adapter pattern was implemented in the EmployeeAdapter.cs file.
The HR system provides employee data as a two-dimensional string array, which is incompatible with the third-party BillingSystem that requires a list of Employee objects. 
The EmployeeAdapter class was created to convert the string array into a list of Employee objects and then pass this list to the billing system's ProcessSalary method. 
This allows integration without modifying either system, enabling them to work together despite having different data formats.

3. Observer Design Pattern

The Observer pattern was completed in the Observer.cs file by implementing the ConcreteObserver class. 
This class stores the observer's name and provides methods to subscribe to and unsubscribe from notifications in the Subject class. 
When the product availability changes, the subject notifies all registered observers by calling their Update method. 
The ConcreteObserver implementation handles these notifications by displaying a message to the user. 
This pattern ensures that observers are automatically updated when the subject's state changes.
