using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CH1ChoiceScript : MonoBehaviour
{
    public GameObject choiceBox;
    public GameObject transitionIn;
    public GameObject transitionOut;

    void Start()
    {
        choiceBox.SetActive(false);
        Invoke("DeactivatePanel", 1f);
    }

    // Update is called once per frame
    public void DialogueCheck()
    {
        FindObjectOfType<DialogueManager2>().EndDialogue();

        choiceBox.SetActive(true);
    }

    public void TruthChoice()
    {
        Invoke("TruthChoiceTransition", 5f);
        transitionOut.SetActive(true);
    }

    public void LieChoice()
    {
        Invoke("LieChoiceTransition", 5f);
        transitionOut.SetActive(true);
    }

    public void TruthChoiceTransition()
    {
        SceneManager.LoadScene("Chapter1-ContinueChoice");
        
    }

    public void LieChoiceTransition()
    {
        SceneManager.LoadScene("Chapter1-BadChoice");
    }

    public void DeactivatePanel()
    {
        transitionIn.SetActive(false);
    }
}
