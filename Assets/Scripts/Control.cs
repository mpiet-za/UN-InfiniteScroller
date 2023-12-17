
using UnityEditor;
using UnityEngine;

public class Control : MonoBehaviour {

    [SerializeField]
    private new Rigidbody rigidbody;

    [SerializeField]
    private float speed = 600f;
    [SerializeField]
    private float glide = 400f;

    private bool keyL = false;
    private bool keyR = false;
    
    void Update() {
        keyL = Input.GetKey(KeyCode.A) ? true : false;
        keyR = Input.GetKey(KeyCode.D) ? true : false;
    }

    void FixedUpdate() {
        
        rigidbody.AddForce(0, 0, speed * Time.deltaTime);
        if (keyL) rigidbody.AddForce(-glide * Time.deltaTime, 0, 0);
        if (keyR) rigidbody.AddForce(+glide * Time.deltaTime, 0, 0);
    }
}
