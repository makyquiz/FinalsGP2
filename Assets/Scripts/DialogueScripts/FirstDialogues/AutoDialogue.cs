using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AutoDialogue : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public Animator animator;

    private Queue<string> sentences;

    public float dialogueSpeed = 0.03f;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue2 dialogue)
    {
        animator.SetBool("isOpen", true);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(dialogueSpeed);
        }
    }

    public void EndDialogue()
    {
        Debug.Log("End Convo");

        animator.SetBool("isOpen", false);
    }
}
