using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingMovement : MonoBehaviour
{
    private float floatingTimer = 0f;
    private float floatingMax = 1f;
    private float floatingDir = 0.08f;

    private void FixedUpdate()
    {
        if (floatingTimer < floatingMax)
        {
            transform.position = new Vector2(transform.position.x,
                transform.position.y + (Time.fixedDeltaTime * floatingDir));
            floatingTimer += Time.fixedDeltaTime;
        }
        else
        {
            floatingDir *= -1;
            floatingTimer = 0f;
        }
    }
}