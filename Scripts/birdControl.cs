
using UnityEngine;

public class birdControl : MonoBehaviour
{
    public Rigidbody rb;

    public float upwardForce = 15;
    public float birdTiltSmoothness = 5;
    Quaternion birdDownRotation;
    Quaternion birdupwardRotation;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        birdDownRotation = Quaternion.Euler(-150, 0, 0); // defininig downward rotation which is of Quaternion.
        birdupwardRotation = Quaternion.Euler(-50, 0, 0);// defininig upward rotation which is of Quaternion.

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // When mouse left button is clicked then bird moves toward up with certain force.
        if (Input.GetMouseButton(0))
        {
            transform.rotation = birdDownRotation;
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * upwardForce , ForceMode.VelocityChange);
        }

        // To mantain the gravit pull of the bird to the ground.
        Physics.gravity = new Vector3(0, -100f, 0);

        // To mantain the smooth transition of the rotation of the bird.
        transform.rotation = Quaternion.Lerp(transform.rotation, birdupwardRotation, birdTiltSmoothness * Time.deltaTime);
    }
}

