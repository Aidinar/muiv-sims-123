
using UnityEngine;

public class ReverseRootMotion : MonoBehaviour
{
    private Vector3 originalPosition;
    void Start()
    {
        originalPosition = transform.localPosition;
    }
    void Update()
    {
        var offset = transform.parent.rotation *
            (transform.localPosition - originalPosition);

        transform.parent.position += offset;
        transform.localPosition = originalPosition;
    }
}


