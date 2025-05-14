using UnityEngine;

public class cubeTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<sceneLoader>().LoadNextScene();
            Debug.Log("Player has entered the trigger");
        }
    }
}
