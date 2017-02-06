[System.Serializable]
public class Item{
	public string name;
	public int price;
	public int amount;

	public Item(string name, int price){
		this.name = name;
		this.price = price;
	}

	public void bought(){
		this.amount++;
	}

	public void used(){
		if (amount > 0)
			amount--;
	}
}
