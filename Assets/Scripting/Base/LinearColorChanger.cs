using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearColorChanger : MonoBehaviour
{
    [HideInInspector]public SpriteRenderer Target;
    [SerializeField] private float _duration;

    private void Start()
    {
        Target = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }
}
