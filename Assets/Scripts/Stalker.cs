
using UnityEditor;
using UnityEngine;

public class Stalker : MonoBehaviour {

    [SerializeField]
    private Transform player;
    [SerializeField]
    private Vector3 offset;
    
    void Update() {
        transform.position = player.position + offset;
    }
}
