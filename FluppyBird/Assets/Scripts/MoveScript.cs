using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private float velocity = 0.65f;

    private void Update()
    {
        transform.position += Vector3.left * velocity * Time.deltaTime;
    }
}
