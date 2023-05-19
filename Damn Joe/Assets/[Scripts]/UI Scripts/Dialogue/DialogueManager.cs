using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private Text _nameText;
    [SerializeField] private Text _dialogueText;

    /// <summary>
    /// ������� ���������� � ����� �������
    /// </summary>
    public Action EndDialogueEvent;

    private Queue<string> _sentences;


    private void Awake()
    {
        _sentences = new Queue<string>();
    }

    /// <summary>
    /// ������ �������
    /// </summary>
    /// <param name="dialogue"></param>
    public void StartDialogue(Dialogue dialogue)
    {
        _nameText.text = dialogue.Name;

        _sentences.Clear();

        foreach (string sentence in dialogue.Sentences)
        {
            _sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    /// <summary>
    /// ����� ���������� ���������
    /// </summary>
    public void DisplayNextSentence()
    {
        if (_sentences.Count == 0)
        {
            EndDialogueEvent?.Invoke();
            return;
        }

        string sentence = _sentences.Dequeue();

        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    /// <summary>
    /// ����������� ����� ������
    /// </summary>
    /// <param name="sentence"></param>
    /// <returns></returns>
    private IEnumerator TypeSentence(string sentence) 
    {
        _dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            _dialogueText.text += letter;
            yield return null;
        }
    }
}
