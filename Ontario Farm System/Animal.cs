internal class Animal
{
    int id;
    string Name;

    //Constructor
    public Animal(string Name)
    {
        this.Name = Name;
    }

    public int GetId()
    {   
        return id;
    }

    public override string ToString()
    {
        return Name;
    }
}