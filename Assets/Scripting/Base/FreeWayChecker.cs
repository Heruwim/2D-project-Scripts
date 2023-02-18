using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeWayChecker : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private ContactFilter2D _filter;
    [SerializeField] private float _speed;

    private readonly RaycastHit2D[] _results = new RaycastHit2D[16];

    private void FixedUpdate()
    {
        var collisionCount = _rigidbody2D.Cast(transform.right, _filter, _results, 10);
        if(collisionCount == 0)
        {
            _rigidbody2D.velocity = transform.right * _speed;
        }
    }
}
