using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleWalk : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    private WalkTarget walkTarget;
    int nextTargetId = 0;
    void Start()
    {
        walkTarget = GetComponent<WalkTarget>();
        SetNextTarget();
    }
    public void SetNextTarget()
    {
        walkTarget.SetTarget(GetNextTarget());
    }
    private Transform GetNextTarget()
    {
        int activeTarget = nextTargetId;
        nextTargetId = (nextTargetId + 1) % waypoints.Length;
        return waypoints[activeTarget];
    }
}
