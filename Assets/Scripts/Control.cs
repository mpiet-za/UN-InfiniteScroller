
using UnityEditor;
using UnityEngine;

/// <summary>
/// Script to enable player movement.
/// </summary>
public class Control : MonoBehaviour {

    [SerializeField] private Rigidbody targetBody;
    [SerializeField] private float movementSpeed = 600f;
    [SerializeField] private float sidewaysForce = 400f;

    private bool shouldGlideLeft = false;
    private bool shouldGlideRight = false;
    
    void Update() {
        shouldGlideLeft = Input.GetKey(KeyCode.A) ? true : false;
        shouldGlideRight = Input.GetKey(KeyCode.D) ? true : false;
    }

    void FixedUpdate() {
        targetBody.AddForce(0, 0, movementSpeed * Time.deltaTime);
        if (shouldGlideLeft) targetBody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        if (shouldGlideRight) targetBody.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
    }
}
