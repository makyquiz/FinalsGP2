using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerMoveToPrologue : MonoBehaviour
{
    public GameObject player;
    public GameObject posToMoveto;
    public GameObject interact;
    public float speed = 5f;

    void Update()
    {
        Invoke("MoveTowardsObject", 2f);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            interact.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            interact.SetActive(false);
        }
    }

    void MoveTowardsObject()
    {
        player.transform.position = Vector2.MoveTowards(player.transform.position, posToMoveto.transform.position, speed * Time.deltaTime);
    }
}
