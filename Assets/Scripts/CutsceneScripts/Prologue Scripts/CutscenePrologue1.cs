using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class CutscenePrologue1 : MonoBehaviour
{
    public CinemachineVirtualCamera Camera1;
    public CinemachineVirtualCamera Camera2;

    public GameObject transition;
    public GameObject transitionIn;

    // Start is called before the first frame update
    void Start()
    {
        Camera1.Priority = 1;
        Camera2.Priority = 0; 
        Invoke("DeactivatePanel", 1f);
    }

    public void DialogueCheck()
    {
        Invoke("CameraTransition", 1f);
        Invoke("NextPrologue",2f);

        FindObjectOfType<DialogueManager2>().EndDialogue();

        transition.SetActive(true);
    }

    public void CameraTransition()
    {
        Camera1.Priority = 0;
        Camera2.Priority = 0;
    }

    public void NextPrologue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void DeactivatePanel()
    {
        transitionIn.SetActive(false);
    }
}
