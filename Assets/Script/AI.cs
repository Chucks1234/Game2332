using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AI : MonoBehaviour
{
    public GameObject player;

    public bool flip;

    public float speed;

    private void Update()
    {
        Vector3 scale = transform.localScale;

        if (player.transform.position.x > transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x) * -1 * (flip ? 1 : -1);
            transform.Translate(speed * Time.deltaTime * -1, 0, 0);
        }
        else
        {
            scale.x = Mathf.Abs(scale.x) * (flip ? 1 : -1);
            transform.Translate(speed * Time.deltaTime * -1, 0, 0);
        }

        transform.localScale = scale;
    }
}