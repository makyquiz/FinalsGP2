using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CH1ContinueScript : MonoBehaviour
{
    public GameObject transition;
    public GameObject transitionIn;
    public GameObject chapterName;
    public GameObject finished;

    private void Start()
    {
        Invoke("DeactivatePanel", 1.5f);
    }

    public void DialogueCheck()
    {
        FindObjectOfType<DialogueManager2>().EndDialogue();

        transition.SetActive(true);

        Invoke("ChapterFinished", 5f);
    }

    public void ChapterFinished()
    {
        chapterName.SetActive(true);
        finished.SetActive(true);
    }

    public void DeactivatePanel()
    {
        transitionIn.SetActive(false);
    }
}
