using System;

// Liskov substituition principle dictates that a sub class should be a substituted by its super class.
// Here we have some examples of bad practices when using inheritance that violates this principle.



interface IEmploymentContract
{
    public void Compensation();
}

class Volunteer : IEmploymentContract
{
    public override void Compensation()
    {
        // does nothing
    }
}

// Throwing an unexpected exception...
class MusicPlayer
{
    public void Play(string file)
    {
        // plays the music
    }
}

class Mp3MusicPlayer : MusicPlayer
{
    public override void Play(string file)
    {
        if (!file.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase))
        {
            throw new Exception();
        }

        // plays the music
    }
}

// Returning values of different types...
class Authentication
{
    public bool CheckCredentials(string login, string password)
    {
        // do something

        return true;
    }
}

class AuthApi : Authentication
{
    public override bool CheckCredentials(string login, string password)
    {
        // do something

        return true; // Or return false, depends on actual implementation
    }
}
