using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sooting : MonoBehaviour
{
    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);

        if (hit)
        {
            Destroy(hit.collider.gameObject);
        }
    }
}
