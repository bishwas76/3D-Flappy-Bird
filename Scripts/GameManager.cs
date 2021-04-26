using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public string activeScene;
    public Rigidbody rb;

    [SerializeField] private Text gameOver;
    [SerializeField] private Button restartButton;
    [SerializeField] private Text restartButtonText;
    [SerializeField] private birdControl birdMovement;
    [SerializeField] private pipesMovement pipe_Movement;
    [SerializeField] private Text scoreBoard;
    [SerializeField] private Button playButton;
    [SerializeField] private Text playButtonText;
    [SerializeField] private Text gameName;

    void Start()
    {
        rb = rb.GetComponent<Rigidbody>();
        birdMovement.enabled = false;
        rb.useGravity = false;
        pipe_Movement.enabled = false;
    }

    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            //Debug.Log("GAME OVER");
            gameOver.enabled = true;
            restartButton.image.enabled = true;
            restartButtonText.enabled = true;
            //Invoke("Restart", 2f); // Invokes certain delay to load the next scene in the game...

        }
    }
    public void PlayButton()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Scene sceneName = SceneManager.GetActiveScene();
        //Debug.Log(sceneName.name);
        if (sceneName.name == "level01")
        {
            birdMovement.enabled = true;
            rb.useGravity = true;
            pipe_Movement.enabled = true;
        }
        scoreBoard.enabled = true;
        playButton.image.enabled = false;
        playButtonText.enabled = false;
        gameName.enabled = false;
    }
    public void RestartButton()
    {
        Restart();
    }
    void Restart()
    {
        // loads the current active scene in which we are in...
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
