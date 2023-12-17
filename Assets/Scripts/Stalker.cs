
using UnityEditor;
using UnityEngine;

public class Stalker : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    
    void Update() {
        transform.position = player.position + offset;
    }
}
