class PostgreConnection
{
    public void Connect()
    {
        Console.WriteLine("Connected to Postgre database.");
    }
}

// DemoRepository is creating a DatabaseConnection by itself, being a clear example of high coupling level.
class DemoRepository
{
    private PostgreConnection dbConnection = new();

    void GetDataFromDatabase()
    {
        dbConnection.Connect();
        // return data
    }
}

// A usual solution is to use Dependency Injection.
// But lets imagine that we are changing our database to MongoDb. 
// Yet again we would need to change this repository implementation, violating the Open Closed Principle
class DemoRepositoryWithDI(PostgreConnection dbConnection)
{
    private PostgreConnection dbConnection = dbConnection;

    void GetDataFromDatabase()
    {
        dbConnection.Connect();
        // return data
    }
}

// The final answer for this is to still use DI, but with an class implementing an interface. 
// So any DatabaseConnection would need to implement it and we wouldnt need to change the repository class

interface IDatabaseConnection
{
    void Connect();
}

class DemoRepositoryWithDIFromAnInterface(IDatabaseConnection dbConnection)
{
    private IDatabaseConnection dbConnection = dbConnection;

    void DoSomething()
    {
        dbConnection.Connect();
        // return data
    }
}
