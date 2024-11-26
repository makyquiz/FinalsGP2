using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class CutscenePrologue2 : MonoBehaviour
{
    public CinemachineVirtualCamera Camera1;
    public CinemachineVirtualCamera Camera2;

    public GameObject transition;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("CameraTransition", 3f);
    }

    public void DialogueCheck()
    {
        FindObjectOfType<DialogueManager2>().EndDialogue();
    }

    public void CameraTransition()
    {
        Camera1.Priority = 0;
        Camera2.Priority = 1;

        transition.SetActive(false);
    }

    public void OntoChapterOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
