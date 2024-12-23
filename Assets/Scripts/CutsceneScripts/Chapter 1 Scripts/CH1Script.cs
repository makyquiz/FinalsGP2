using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CH1Script : MonoBehaviour
{
    public GameObject transition;
    public GameObject transitionIn;

    public void Start()
    {
        Invoke("DeactivatePanel", 1f);
    }

    public void DialogueCheck()
    {
        FindObjectOfType<DialogueManager2>().EndDialogue();

        transition.SetActive(true);

        Invoke("NextPart", 2f);
    }

    public void NextPart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void DeactivatePanel()
    {
        transitionIn.SetActive(false);
    }
}
