using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobsterAnimControl : MonoBehaviour
{
    [SerializeField] Animator anim;  // Reference to the Animator component

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))  // It's better to use CompareTag instead of == for performance reasons
        {
            anim.SetTrigger("isPunch");  // Trigger the punch animation
            StartCoroutine(WaitAndLoadScene());  // Start the coroutine for waiting and then loading the scene
        }
    }

    // Coroutine to wait and load the scene
    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(2);  // Wait for 1 second
        Debug.Log("Dead");  // Print to the console for debugging
        SceneManager.LoadScene(0);  // Load the scene at index 0 (main menu or another scene)
    }
}
