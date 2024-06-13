using UnityEngine;

public class spindleResetPosition : MonoBehaviour
{
    private readonly Experiment manager;
    public Transform startLocation01;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.GetComponent<LM_PlayerController>() != null)
        {
            Debug.Log("Before resetting position: Coordinates are " + other.transform.position);
            other.gameObject.transform.position = startLocation01.position;
            Debug.Log("After resetting position: Coordinates are " + other.transform.position);
        }
        Debug.Log("Current Position is " + other.transform.position);
    }
}