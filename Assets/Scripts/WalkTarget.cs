using UnityEngine;

public class WalkTarget : MonoBehaviour
{
    [SerializeField] Transform target;
    public void SetTarget(Transform  value)
    {
        target = value;
        transform.LookAt(
            new Vector3(
                target.position.x,
                transform.position.y,
                target.position.z
            ));

    }
    public void Start()

    {
        if (target) SetTarget(target);

    }
     void OnTriggerEnter(Collider trigger)

    {
        if (trigger.transform == target)
        {
            print($"{name}дошел до цели"); ;

        }
    }
}
