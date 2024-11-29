using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CH1ContinueScript : MonoBehaviour
{
    public GameObject transition;
    public GameObject transitionIn;

    public GameObject chapterName;
    public GameObject finished;
    public GameObject nextChapterName;
    public GameObject tbcText;

    public GameObject menuButton;

    private void Start()
    {
        Invoke("DeactivatePanel", 1.5f);
    }

    public void DialogueCheck()
    {
        FindObjectOfType<DialogueManager2>().EndDialogue();

        transition.SetActive(true);

        Invoke("ChapterFinished", 5f);
        Invoke("NextChapterName", 10f);
    }

    public void ChapterFinished()
    {
        chapterName.SetActive(true);
        finished.SetActive(true);
    }

    void NextChapterName()
    {
        chapterName.SetActive(false);
        finished.SetActive(false);
        nextChapterName.SetActive(true);
        tbcText.SetActive(true);
        menuButton.SetActive(true);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void DeactivatePanel()
    {
        transitionIn.SetActive(false);
    }
}
