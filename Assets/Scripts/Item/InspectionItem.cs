using System;
using UnityEngine;
using Zenject;

public class InspectionItem : MonoBehaviour, IItem
{
    [Inject] private ItemsHandler _itemsHandler;
    [SerializeField] private string _name;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private bool DestroyAfterClick;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;

    public Sprite Sprite => _sprite;
    
    public event Action<InspectionItem> OnInteracted;

    private void OnEnable()
    {
        _itemsHandler.Add(this);
        if (_audioSource != null)
        {
            _audioSource.clip = _audioClip;
        }
    }

    public void Interact(Player player)
    {
        OnInteracted?.Invoke(this);

        if (_audioSource != null && _audioSource.clip != null)
        {
            _audioSource.Play();
        }
        if (!player.IsItemInInventory(_name) && DestroyAfterClick)
        {
            player.AddItemInInventory(_name);
            _itemsHandler.Remove(this);
            Destroy(gameObject);
        }
    }
}