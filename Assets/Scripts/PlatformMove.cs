using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float speed = 0.60f;
    private float waitTime;
    public Transform[] moveDirection;
    public float startWaitTime = 1.5f;
    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveDirection[i].transform.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveDirection[i].transform.position) < 0.1f)
        {
            if (waitTime <= 0)

            {
                if (moveDirection[i] != moveDirection[moveDirection.Length - 1])
                {
                    i++;
                }

                waitTime = startWaitTime;

            }
            else
            {
                waitTime -= Time.deltaTime;
            }

        }
    }
}
