
using UnityEngine;

public class cameraPlacement : MonoBehaviour
{
    public Transform bird;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = bird.position + new Vector3(0, 6f, -3f) + offset;
    }
}
