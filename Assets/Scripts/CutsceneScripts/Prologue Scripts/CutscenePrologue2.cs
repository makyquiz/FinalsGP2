using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class CutscenePrologue2 : MonoBehaviour
{
    public CinemachineVirtualCamera Camera1;
    public CinemachineVirtualCamera Camera2;

    public GameObject transitionOut;
    public GameObject transitionIn;
    public GameObject choiceBox;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("CameraTransition", 3f);

        transitionOut.SetActive(true);
        transitionIn.SetActive(false);
        choiceBox.SetActive(false);

    }

    public void DialogueCheck()
    {
        FindObjectOfType<DialogueManager2>().EndDialogue();

        choiceBox.SetActive(true);
    }

    public void CameraTransition()
    {
        Camera1.Priority = 0;
        Camera2.Priority = 1;

        transitionOut.SetActive(false);
    }

    public void OntoChapter1Transition()
    {
        Invoke("OntoChapter1Choice", 2f);
        transitionIn.SetActive(true);
    }

    public void BadEndTransition()
    {
        Invoke("BadEndChoice", 2f);
    }

    public void OntoChapter1Choice()
    {
        SceneManager.LoadScene("Chapter1");
    }

    public void BadEndChoice()
    {
        SceneManager.LoadScene("PrologueBadEnd");
        
    }
}
