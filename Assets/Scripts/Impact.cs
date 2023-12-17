
using UnityEngine;

/// <summary>
/// Script to handle player collision events.
/// </summary>
public class Impact : MonoBehaviour {

    [SerializeField] private Control controller;

    void OnCollisionEnter(Collision colsn) {
        eventLog(colsn);
        if (colsn.collider.tag == "Obstacle") controller.enabled = false;
    }

    private void eventLog(Collision colsn) {
        Debug.Log("Hit: " + colsn.collider.tag + " / " + colsn.collider.name);
    }
}
