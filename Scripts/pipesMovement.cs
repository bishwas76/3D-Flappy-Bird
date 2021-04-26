using UnityEngine;

public class pipesMovement : MonoBehaviour
{
    [SerializeField]  private float speed;
    void Update()
    {
        //Changing the postion of the pipes for the movement.
        transform.position += Vector3.back * (speed * Time.fixedDeltaTime);
    }
}
