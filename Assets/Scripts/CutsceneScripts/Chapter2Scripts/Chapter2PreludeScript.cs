using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chapter2PreludeScript : MonoBehaviour
{
    public GameObject startConvo;
    public GameObject badEndText;
    public GameObject tryAgainText;

    public GameObject menuButton;

    public void DialogueCheck()
    {
        FindObjectOfType<DialogueManager2>().EndDialogue();

        Invoke("BadEndShow", 4f);

        startConvo.SetActive(false);
    }

    void BadEndShow()
    {
        badEndText.SetActive(true);
        tryAgainText.SetActive(true);
        menuButton.SetActive(true);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
