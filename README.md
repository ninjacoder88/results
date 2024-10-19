```
public class Processor
{
	public Result DoSomethingSuccessfully()
	{
		return new Success();
	}

	public Result DoSomethingThatFails()
	{
		return new Failure("something went wrong");
	}

	public Result<Item> DoSomethingGenericallySuccessful()
	{
		return new Success<Item>(new Item(1, "A"));
	}

	public Result<Item> DoSomethingThatGenericallyFails()
	{
		return new Failure<Item>("something went wrong");
	}
}


public class Item
{
	public Item(int id, string name)
	{
		Id = id;
		Name = name;
	}

	public int Id {get;}

	public string Name {get;}
}
```