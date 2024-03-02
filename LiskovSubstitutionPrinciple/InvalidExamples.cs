using System;

// Liskov substituition principle dictates that a sub class should be a substituted by its super class.
// Here we have some examples of bad practices when using inheritance that violates this principle.


// IEmploymentContract interface dictates that any format of employment should have a compensation.
// But a volunteer receives nothing from the company, so to implement that interface it has to make no operations.
// Volunteer should not implement it, in a case where theres another methods to be implemented,
// perphaps chaining the interfaces could be a possible solution
interface IEmploymentContract
{
    public void CalculateCompensation();
}

class Volunteer : IEmploymentContract
{
    public void CalculateCompensation()
    {
        // does nothing
    }
}

// Here, any class inhereting from MusicPlayer should have a Play method.
// But lets say only Mp3MusicPlayer could have a scenario where a file cant be found and so will trhow an exception,
// this could lead to a exception going up the pipeline and causing unexpected behaviour 
class MusicPlayer
{
    public virtual void Play(string songName)
    {
        // plays the music
        // no exception predicted here
    }
}

class Mp3MusicPlayer : MusicPlayer
{
    public override void Play(string songName)
    {
        if (!File.Exists(songName + ".mp3"))
            throw new Exception();

        // plays the music
    }
}

// Changing a return type can also lead to exceptions unexpected behaviour
class Authentication
{
    public virtual object CheckCredentials(string login, string password)
    {
        // do something
        return true;
    }
}

class AuthApi : Authentication
{
    public override object CheckCredentials(string login, string password)
    {
        // do something
        return (valid: true, statusCode: 200);
    }
}
