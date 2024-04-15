using UnityEngine;
using UnityEngine.UI;
using Valve.VR; 

public class NPC : MonoBehaviour
{
    public GameObject uiPanel; 
    

    private bool isPlayerNearby = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("enter");
            isPlayerNearby = true;
            uiPanel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
            uiPanel.SetActive(false);
        }
    }
}
