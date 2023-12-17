
using UnityEngine;

/// <summary>
/// Script to force camera to follow player.
/// </summary>
public class Stalker : MonoBehaviour {

    [SerializeField] private Transform targetObject;
    [SerializeField] private Vector3 cameraOffset;
    
    void Update() {
        transform.position = targetObject.position + cameraOffset;
    }
}
