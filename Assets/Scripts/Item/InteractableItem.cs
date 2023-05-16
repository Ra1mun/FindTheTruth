using UnityEngine;

public class InteractableItem : MonoBehaviour, IItem
{
    [SerializeField] private string _name;
    public void Interact(Player player)
    {
        if (!player.IsItemInInventory(_name))
        {
            player.AddItemInInventory(_name);
            Destroy(gameObject);
        }
            
    }
}