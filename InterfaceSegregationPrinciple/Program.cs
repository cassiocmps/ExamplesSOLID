interface IBird
{
    void SetLocation(double longitude, double latitude);
    void SetAltitude(double altitude);
}

class Parrot : IBird
{
    public void SetLocation(double longitude, double latitude)
    {
        // Do something
    }

    public void SetAltitude(double altitude)
    {
        // Do something
    }
}

// Class implementing the IBird interface
class Penguin : IBird
{
    public void SetLocation(double longitude, double latitude)
    {
        // Do something
    }

    // The IBird interface is forcing the Penguin class to implement this method.
    public void SetAltitude(double altitude)
    {
        // Doesn't do anything... Penguins are birds that do not fly!
    }
}