
public enum Rating
{ Good, Great, Excellent }

struct Dog
{

    public string name { get; }
    public float age { get; }
    public string owner { get; }
    public Rating rating { get; }
    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }

}
