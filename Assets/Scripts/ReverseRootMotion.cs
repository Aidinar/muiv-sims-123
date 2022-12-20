
using UnityEngine;

public class ReverseRootMotion : MonoBehaviour
{
    private Vector3 originalPosition;
    void start()
    {
        originalPosition = transform.localPosition;

    }
    void update()
    {
        var offset = transform.parent.rotation *
            (transform.localPosition - originalPosition);
            
        transform.parent.position +=
            transform.localPosition - originalPosition;
        transform.localPosition = originalPosition;


    }
}


