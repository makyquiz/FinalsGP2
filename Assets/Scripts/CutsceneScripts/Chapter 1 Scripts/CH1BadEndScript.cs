using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CH1BadEndScript : MonoBehaviour
{
    public GameObject finalConvo;
    public GameObject transitionFade;
    public GameObject transitionIn;
    public GameObject transitionCut;

    public void Start()
    {
        finalConvo.SetActive(false);
        transitionCut.SetActive(false);
        Invoke("DeactivatePanel", 1.5f);
    }

    public void DialogueCheck()
    {
        FindObjectOfType<DialogueManager2>().EndDialogue();

        transitionFade.SetActive(true);

        Invoke("SecondConvo", 5f);
    }

    public void SecondConvo()
    {
        finalConvo.SetActive(true);
    }

    public void DeactivatePanel()
    {
        transitionIn.SetActive(false);
    }
}
