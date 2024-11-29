using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CH1BadEndScript : MonoBehaviour
{
    public GameObject transitionFade;
    public GameObject transitionIn;
    public GameObject transitionCut;

    public void Start()
    {
        transitionCut.SetActive(false);
        Invoke("DeactivatePanel", 1.5f);
    }

    public void DialogueCheck()
    {
        FindObjectOfType<DialogueManager2>().EndDialogue();

        transitionFade.SetActive(true);

        Invoke("BadEndCont", 5f);
    }

    public void BadEndCont()
    {
        SceneManager.LoadScene("Ch1BadEndCont");
    }

    public void DeactivatePanel()
    {
        transitionIn.SetActive(false);
    }
}
