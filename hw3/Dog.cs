namespace hw3;

public class Dog
{
    string? _name;
    string? _breed;
    int _age;
    public Dog(string name,string breed,int age)
    {
        _name=name;
        _breed=breed;
        _age=age;
    }
    public void Get()
    {
        System.Console.WriteLine($"Name:{_name}\nBreed:{_breed}\nAge:{_age}");
    }

}
