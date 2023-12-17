
using UnityEditor;
using UnityEngine;

public class Control : MonoBehaviour {

    public new Rigidbody rigidbody;

    public float speed = 600f;
    public float glide = 400f;

    private bool keyL = false;
    private bool keyR = false;
    
    void Start() {
        
    }

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
