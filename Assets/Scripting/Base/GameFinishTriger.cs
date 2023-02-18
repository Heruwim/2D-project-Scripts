using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinishTriger : MonoBehaviour
{
    private EndPoint[] _points;

    private void OnEnable()
    {
        _points = gameObject.GetComponentsInChildren<EndPoint>();

        foreach (var point in _points)
            point.Reached += OnEndPointReach;
    }

    private void OnDisable()
    {
        foreach (var point in _points)
            point.Reached -= OnEndPointReach;
    }

    private void OnEndPointReach()
    {
        foreach (var point in _points)
            if (point.IsReached == false)
                return;

        Debug.Log("Finish");
    }
}
