
using UnityEngine;

public class GirrStory1 : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider collider)
    {
        print($"{collider.name}enter girl collider");
    }
}
