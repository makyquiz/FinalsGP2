using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutscenePostPrologue : MonoBehaviour
{
    public GameObject transition;
    public GameObject transitionIn;

    public GameObject chapterName;
    public GameObject finished;
    public GameObject nextChapterName;

    public void Start()
    {
        Invoke("DeactivatePanel", 1f);
    }

    public void DialogueCheck()
    {
        FindObjectOfType<DialogueManager2>().EndDialogue();

        transition.SetActive(true);

        Invoke("OntoChapterOne", 15f);
        Invoke("PrologueFinished", 5f);
        Invoke("NextChapterName", 10f);
    }

    public void OntoChapterOne()
    {
        SceneManager.LoadScene("Chapter1");
    }

    public void PrologueFinished()
    {
        chapterName.SetActive(true);
        finished.SetActive(true);
    }
    
    public void NextChapterName()
    {
        nextChapterName.SetActive(true);
        chapterName.SetActive(false);
        finished.SetActive(false);
    }

    public void DeactivatePanel()
    {
        transitionIn.SetActive(false);
    }
}
