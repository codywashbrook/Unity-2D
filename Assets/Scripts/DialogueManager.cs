using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueUI;
    public TextMeshProUGUI dialogueText;

    public GameObject player;
    public Animator animator;

    private Queue<string> dialogue;

    // Checks current state of the dialogue
    public bool dialogueEnded = false;

    // Start is called before the first frame update
    private void Start()
    {
        dialogue = new Queue<string>();
    }

    public void StartDialogue(string[] sentences)
    {
        dialogueEnded = false;
        dialogue.Clear();
        dialogueUI.SetActive(true);

        player.GetComponent<PlayerMovement_2D>().enabled = false;
        player.GetComponent<PlayerInteractable>().enabled = false;
        animator.SetFloat("Speed", 0);
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        foreach (string currentLine in sentences)
        {
            dialogue.Enqueue(currentLine);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (dialogue.Count == 0)
        {
            //Remove GameObjects
            EndDialogue();
            return;
        }
        string currentLine = dialogue.Dequeue();
        dialogueText.text = currentLine;
    }
    private void EndDialogue()
    {
        dialogueEnded = true;
        dialogueUI.SetActive(false);
        player.GetComponent<PlayerMovement_2D>().enabled = true;
        player.GetComponent<PlayerInteractable>().enabled = true;
    }
}
