using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Roced : MonoBehaviour
{

    [SerializeField] float rcsThrust = 100f;
    [SerializeField] float mainThrust = 100f;
    [SerializeField] float levelLoadDelay = 2f;

    [SerializeField] AudioClip success;
    [SerializeField] AudioClip mainEngine;
    [SerializeField] AudioClip deathSound;

    [SerializeField] ParticleSystem successParticles;
    [SerializeField] ParticleSystem mainEngineParticles;
    [SerializeField] ParticleSystem deathSoundParticles;

    Rigidbody rigidBody;
    AudioSource audio;


    enum State
    {
        Alive,
        Dying,
        Transcending,
    }

    bool collisionAreDisabled = false;

    //public Text scoreText;

    State state = State.Alive;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // To do (Stop sound when die)
        if (state == State.Alive)
        {
            RespondToThrustInput();
            RespondToRotateInput();
        }
        if (Debug.isDebugBuild)
        {
            RespondToDebugKeys();
        }
    }

    private void RespondToDebugKeys()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadNextScene();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            collisionAreDisabled = !collisionAreDisabled;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
            SceneManager.LoadScene(0);
    }

    private void RespondToThrustInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ApplyThrust();
        }
        else
        {
            StopApplyingThrust();
        }
    }

    private void StopApplyingThrust()
    {
        audio.Stop();
        mainEngineParticles.Stop();
    }

    private void ApplyThrust()
    {
        rigidBody.AddRelativeForce(Vector3.up * mainThrust);
        if (!audio.isPlaying) // so the sound doesn't layer
        {
            audio.PlayOneShot(mainEngine);
        }
        if (!mainEngineParticles.isPlaying)
        {
            mainEngineParticles.Play();
        }

    }

    private void RespondToRotateInput()
    {
        rigidBody.angularVelocity = Vector3.zero; // remove rotation due to physics


        float rotationThisFrame = rcsThrust * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(Vector3.forward * rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }

        rigidBody.freezeRotation = false; // resume physics control of rocket
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (state != State.Alive || collisionAreDisabled) { return; }

        switch (collision.gameObject.tag)
        {
            case "Friendly":
                break;
            case "Finish":
                StartSuccessSequence();
                break;
            default:
                StartDeathSequence();
                break;



        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "star")
        {
            //scoreText.text = (int.Parse(scoreText.text) + 5).ToString();
            Destroy(col.gameObject);
        }
    }

    private void StartDeathSequence()
    {
        state = State.Dying;
        audio.Stop();
        audio.PlayOneShot(deathSound);
        if (!deathSoundParticles.isPlaying)
        {
            deathSoundParticles.Play();
        }
        //Invoke("LoadCurrentScene", levelLoadDelay);
        UIHandler.instance.ShowLevelDialogFailed();
        //To do kill player
    }

    private void StartSuccessSequence()
    {
        state = State.Transcending;
        audio.Stop();
        audio.PlayOneShot(success);
        if (!successParticles.isPlaying)
        {
            successParticles.Play();
        }
       // UIHandler.instance.ShowLevelDialog("Level Cleared", scoreText.text);
        //Invoke("LoadNextScene", levelLoadDelay); //Paramaterise this time
    }

    private void LoadFirstLevel()
    {
        SceneManager.LoadScene(0);
    }


    private void LoadNextScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0; // Loops the game back to start.
        }
        SceneManager.LoadScene(nextSceneIndex);
    }

    private void LoadCurrentScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);

    }



}


