using UnityEngine;
using UnityEngine.Events;

public class WalkTarget : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] UnityEvent OnTargetEnter;
    public void SetTarget(Transform  value)
    {
        if (value)
        {
            target = value;
            transform.LookAt(
                new Vector3(
                    target.position.x,
                    transform.position.y,
                    target.position.z
                ));
        }
        else
        {
            GetComponentInChildren<Animator>().Play("New State 0");
        }
    }
    public void Start()

    {
        if (target) SetTarget(target);

    }
     void OnTriggerEnter(Collider trigger)

    {
        if (trigger.transform == target)
        {
            OnTargetEnter.Invoke();
        }
    }
}
