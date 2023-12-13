using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text dialogueText; // Change from Text to TMP_Text for TextMeshPro
    public Button nextButton;

    public string[] dialogues = {
        "Hello, adventurer!",
        "Welcome to the enchanted forest.",
        "Beware of magical creatures.",
        "Find the hidden treasure!"
    };

    void Start()
    {
        nextButton.onClick.AddListener(NextDialogue);
        NextDialogue();
    }

    void NextDialogue()
    {
        int randomIndex = Random.Range(0, dialogues.Length);
        dialogueText.text = dialogues[randomIndex];
    }
}