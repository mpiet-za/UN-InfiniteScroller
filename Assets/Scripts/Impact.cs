
using UnityEngine;

public class Impact : MonoBehaviour {

    [SerializeField]
    private Control controller;

    void OnCollisionEnter(Collision collision) {
        Debug.Log("Hit: " + collision.collider.tag);
        // Disable player movement on collision event triggered
        if (collision.collider.tag == "Obstacle") controller.enabled = false;
    }
}
