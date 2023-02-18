using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _rechedColor;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player2D>(out Player2D player))
        {
            _renderer.color = _rechedColor;
        }
    }
}
