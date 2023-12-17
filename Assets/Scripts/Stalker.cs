
using UnityEngine;

/// <summary>
/// Script to force camera to follow player.
/// </summary>
public class Stalker : MonoBehaviour {

    [SerializeField] private Transform player;
    [SerializeField] private Vector3 cameraOffset;
    
    void Update() {
        transform.position = player.position + cameraOffset;
    }
}
