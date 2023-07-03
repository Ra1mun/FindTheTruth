using System;
using HeneGames.DialogueSystem;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;
using Zenject;

public class InitialScene : MonoBehaviour
{
    [SerializeField] private PlayableDirector _director;
    private DialogueManager _dialogueManager;
    [Inject] private InputHandler _inputHandler;
    private bool fix = false;

    private void Awake()
    {
        Debug.Log(DataHolder.GameStart);
        if (DataHolder.GameStart)
        {
            Destroy(_director.gameObject);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (_director.state != PlayState.Playing && !fix)
        {
            BeginDialogue();
            fix = true;
        }
    }
    
    private void BeginDialogue()
    {
        _dialogueManager = GetComponent<DialogueManager>();
        DialogueUI.instance.StartDialogue(_dialogueManager);
    }

    public void EndDialogue()
    {
        DataHolder.GameStart = true;
        Destroy(_director.gameObject);
        Destroy(gameObject);
    }
}
