using UnityEngine;

public class DefeatSceneDialogueClosed : WindowManager
{
  
    [SerializeField]  private DialogueManager _dialogueManagerPlayer;
    [SerializeField]  private DialogueManager _dialogueManagerCrow;

    private bool _isEndDialoguePlayer;
    private bool _isEndDialogueCrow;

    private void OnEnable()
    {
        _dialogueManagerCrow.EndDialogueEvent += EndDialogueCrow;
        _dialogueManagerPlayer.EndDialogueEvent += EndDialoguePlayer;
    }
    private void OnDisable()
    {
        _dialogueManagerCrow.EndDialogueEvent -= EndDialogueCrow;
        _dialogueManagerPlayer.EndDialogueEvent -= EndDialoguePlayer;
    }

    private void EndDialoguePlayer()
    {
        _isEndDialoguePlayer = true;

        if (_isEndDialogueCrow) 
        {
            ButtonPress();
        }
    } 
    private void EndDialogueCrow()
    {
        _isEndDialogueCrow = true;
        
        if (_isEndDialoguePlayer)
        {
            ButtonPress();
        }
    }
}
