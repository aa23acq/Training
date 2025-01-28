// See https://aka.ms/new-console-template for more information
using Training;

Console.WriteLine("Hello, World!");


//Creational Design Patterns
//1. Singleton
//2. Factory
//3. Abstract Factory
//4. Builder
//5. Prototype

//Structural Design Patterns
//1. Adapter
//2. Decorator
//3. Facade
//4. Proxy

// Behavioral Design Patterns
//1. Chain of Responsibility
//2. Observer
//3. Strategy
//4. Command
//var circle = new Circle(5);
//var circle2 = new Circle(10);
//var logger1 = Logger.Instance;
//var logger2 = Logger.Instance;
//logger1.Log($"Area of Circle: {circle.Area()}");
//logger2.Log($"Area of Circle: {circle2.Area()}");
//var square = new Square(5);
//logger2.Log($"Area of Square: {square.Area()}");

//logger2.Log($"Are both instances the same? {ReferenceEquals(logger1, logger2)}");

//logger2.Log($"Are both instances the same? {ReferenceEquals(circle, circle2)}");

//IHouseBuilder builder = new HouseBuilder();
//Logger.Instance.Log(builder.BuildWalls(4).BuildDoors(2).BuildWindows(4).BuildRoof().Build().ToString());

//var user1 = new User("John Doe", "123 Main St", "john@gmail.com");
//var product1 = new Product(1,"Laptop", 1000);
//var initialPurchase = new Purchase
//{
//    User = user1,
//    Product = product1,
//    Date = DateTime.Now,
//    Operation = Operation.SELL,
//    Amount = 100
//};

//initialPurchase.GenerateReceipt();
//var user2 = new User("Jane Doe", "123 Main St", "jane#gmail.com");
//var clonedPurchase = initialPurchase.CloneAndModify(user:user2, amount:300);
//clonedPurchase.GenerateReceipt();

IPaymentProcessor paymentProcessor = new IntrernalPaymentProcessor();
paymentProcessor.ProcessPayment(100, "1234567890");

Console.WriteLine(paymentProcessor.ToString());

var thirdPartyPaymentProcessor = new ThirdPartyPaymentProcessor();
IPaymentProcessor paymentAdapter = new PaymentAdapter(thirdPartyPaymentProcessor);
paymentAdapter.ProcessPayment(200, "0987654321");
Console.WriteLine(paymentAdapter.ToString());

Console.WriteLine($"Are both instances the same? {ReferenceEquals(paymentProcessor, paymentAdapter)}");



