using UnityEngine;

public class GirrStory1 : MonoBehaviour
{

    public void Talk()
    {
        var inkComponent = FindObjectOfType<InkTestingScript>();
        inkComponent.refreshUI();
    }
}
