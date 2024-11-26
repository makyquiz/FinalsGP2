using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager2 : MonoBehaviour
{
    public GameObject dialogueBox;
    public GameObject startBox;
    public GameObject continueBox;
    public GameObject endBox;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public Animator animator;

    private Queue<string> sentences;
    private Queue<string> names;

    public float dialogueSpeed = 0.03f;

    void Start()
    {
        sentences = new Queue<string>();
        names = new Queue<string>();
        endBox.SetActive(false);
    }
    
    public void StartDialogue(Dialogue2 dialogue)
    {
        startBox.SetActive(false);
        dialogueBox.SetActive(true);
        
        animator.SetBool("isOpen", true);

        names.Clear();
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);    
        }
        
        foreach(string name in dialogue.names)
        {
            names.Enqueue(name);    
        }

        DisplayNext();
        
    }

    public void DisplayNext()
    {
        if (names.Count > 0)
        {
            string name = names.Dequeue();
            nameText.text = name;
        }
        else
        {
            nameText.text = "";
        }

        if (sentences.Count > 0)
        {
            string sentence = sentences.Dequeue();
            
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));

            if(sentences.Count == 0)
            {
                continueBox.SetActive(false);
                endBox.SetActive(true);
            }
        }
        else
        {
            EndDialogue();
        }
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";

        foreach(char letter  in sentence.ToCharArray())
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
