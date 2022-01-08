using UnityEngine;

public class houseColider : MonoBehaviour
{
    public ButtonManager buttonManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            buttonManager.enter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            buttonManager.enter = false;
        }
    }
}
