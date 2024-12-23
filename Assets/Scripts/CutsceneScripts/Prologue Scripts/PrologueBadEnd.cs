using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrologueBadEnd : MonoBehaviour
{
    public GameObject cutToBlack;
    public GameObject badEndText;
    public GameObject tryAgainText;

    public GameObject menuButton;

    void Start()
    {
        Invoke("CutToBlack", 4.2f);
        Invoke("BadEndShow", 8.4f);
    }

    void CutToBlack()
    {
        cutToBlack.SetActive(true);
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
