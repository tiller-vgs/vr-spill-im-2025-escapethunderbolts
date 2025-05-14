using UnityEngine;

public class cubeTrigger : MonoBehaviour
{
    // This method is called when another object enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object has a specific tag (optional)
        if (other.CompareTag("Player"))
        {
            GetComponent<sceneLoader>().LoadNextScene();
            Debug.Log("Player has entered the trigger");
        }
    }
}
