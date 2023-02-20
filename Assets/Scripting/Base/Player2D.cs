using UnityEngine;
using UnityEngine.Events;

public class Player2D : MonoBehaviour
{
    [SerializeField] private UnityEvent _hit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.gameObject.name);
        if(collision.collider.TryGetComponent(out Block block))
        {
            _hit?.Invoke();
        }
    }
}
