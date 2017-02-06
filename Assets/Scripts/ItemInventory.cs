using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "Data/Item", order = 1)]
public class ItemInventory : ScriptableObject {
	public List<Item> itemList;
}
