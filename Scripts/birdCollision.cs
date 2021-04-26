using UnityEngine;

public class birdCollision : MonoBehaviour
{
   [SerializeField] private birdControl movement;
    [SerializeField] private sceneSpawner scene;
    [SerializeField] private pipesMovement birdForwardMovement;
    [SerializeField] private Score scoreTrigger;

    //Game ending collision..
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "pipe_ground")
        {
            //Debug.Log(collisionInfo.collider.tag);
            movement.enabled = false;
            birdForwardMovement.enabled = false;
            GameManager gameOver = FindObjectOfType<GameManager>();
            if (gameOver != null)
            {
                gameOver.EndGame();
            }
        }
        else if (collisionInfo.collider.tag == "pipe")
        {
            //Debug.Log(collisionInfo.collider.tag);
            movement.enabled = false;
            birdForwardMovement.enabled = false;
            GameManager gameOver = FindObjectOfType<GameManager>();
            if (gameOver != null)
            {
                gameOver.EndGame();
            }
        }
    }

    void OnTriggerEnter(Collider colliderinfo)
    {
        //Collision Trigger for spawning game ground scenes...
        if (colliderinfo.CompareTag("spawnTrigger"))
        {
            scene.FieldSpawner();
        }
        //Collision for generating score in the game...
        else if (colliderinfo.CompareTag("score"))
        {
            scoreTrigger.GameScore();
        }
    }
}
