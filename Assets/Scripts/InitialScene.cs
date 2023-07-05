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
    [SerializeField] private CanvasGroup _canvasGroup;

    private void Awake()
    {
        if (DataHolder.GameStart)
        {
            Destroy(_director.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        _director.stopped += BeginDialogue;
    }

    private void BeginDialogue(PlayableDirector director)
    {
        _canvasGroup.Open();
        Destroy(director.gameObject);
        _dialogueManager = GetComponent<DialogueManager>();
        DialogueUI.instance.StartDialogue(_dialogueManager);
    }

    public void EndDialogue()
    {
        DataHolder.GameStart = true;
        Destroy(gameObject);
    }

    private void OnDisable()
    {
        _director.stopped -= BeginDialogue;
    }
}
