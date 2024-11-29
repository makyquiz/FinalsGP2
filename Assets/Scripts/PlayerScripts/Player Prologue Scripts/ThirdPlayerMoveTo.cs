using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPlayerMoveTo : MonoBehaviour
{

    public GameObject player;
    public GameObject posToMoveto;
    public float speed = 2f;

    void Update()
    {
        Invoke("MoveTowardsObject", 3f);
    }

    void MoveTowardsObject()
    {
        player.transform.position = Vector2.MoveTowards(player.transform.position, posToMoveto.transform.position, speed * Time.deltaTime);
    }
}
