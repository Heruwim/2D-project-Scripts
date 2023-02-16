using UnityEngine;

public class LifeTime : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        
    }
}
