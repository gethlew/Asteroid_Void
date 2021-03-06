﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwordRocket : MonoBehaviour
{

    Rigidbody rigidBody;

    private float moveSpeed, jumpForce;

    private bool moveLeft, moveRight, moveUp;

    enum State
    {
        Alive,
        Dying,
        Transcending,
    }

    bool collisionAreDisabled = false;

    public Text scoreText;

    public int life = 3;

    public GameObject[] hearts;

    State state = State.Alive;

    [SerializeField] float levelLoadDelay = 2f;

    [SerializeField] AudioClip success;
    [SerializeField] AudioClip mainEngine;
    [SerializeField] AudioClip deathSound;

    [SerializeField] ParticleSystem successParticles;
    [SerializeField] ParticleSystem mainEngineParticles;
    [SerializeField] ParticleSystem deathSoundParticles;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
        moveSpeed = 5f;
        jumpForce = 500f;
        moveLeft = false;
        moveRight = false;
        life = 3;
        if (life == 3)
        {
            hearts[0].SetActive(true);
            hearts[1].SetActive(true);
            hearts[2].SetActive(true);
        }
        int currIndex = SceneManager.GetActiveScene().buildIndex;
        if (currIndex > 30)
        {
            life = 1;
        }
    }
    private void RespondToDebugKeys()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadNextScene();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            LoadCurrentScene();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            collisionAreDisabled = !collisionAreDisabled;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
            SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        if (moveLeft)
        {
            rigidBody.velocity = new Vector3(-moveSpeed, 0f);

        }

        if (moveRight)
        {
            rigidBody.velocity = new Vector3(moveSpeed, 0f);
        }

       if (moveUp)
        {
            rigidBody.AddRelativeForce(Vector3.up * 10f);
        }
        if (life == 2)
        {
            hearts[0].SetActive(true);
            hearts[1].SetActive(true);
            hearts[2].SetActive(false);
        }
        if (life == 3)
        {
            hearts[0].SetActive(true);
            hearts[1].SetActive(true);
            hearts[2].SetActive(true);
        }
        if (life == 1)
        {
            hearts[0].SetActive(true);
            hearts[1].SetActive(false);
            hearts[2].SetActive(false);
        }
        if (life == 0)
        {
            hearts[0].SetActive(false);
            state = State.Dying;
            StartDeathSequence();
        }
        if (Debug.isDebugBuild)
        {
            RespondToDebugKeys();
        }
    }

    /*
    public void MoveLeft()
    {
        moveLeft = true;
    }

    public void MoveRight()
    {
        moveRight = true;
    }
    */

    public void MoveLeft()
    {

        rigidBody.angularVelocity = Vector3.zero;
        //float rotationThisFrame = 500f * Time.deltaTime;
        transform.Rotate(Vector3.forward * 25f);
        //moveLeft = true;
    }

    public void MoveRight()
    {
        rigidBody.angularVelocity = Vector3.zero;
        //float rotationThisFrame = 500f * Time.deltaTime;
        transform.Rotate(-Vector3.forward * 25f);
        
    }

    public void MoveUp()
    {
        moveUp = true;
        //if (!audio.isPlaying) // so the sound doesn't layer
        //{
            audio.PlayOneShot(mainEngine);
        //}
        if (!mainEngineParticles.isPlaying)
        {
            mainEngineParticles.Play();
        }

    }
   /* public void Jump()
    {
       if (rigidBody.velocity.y == 0)
        {
            rigidBody.AddRelativeForce(Vector3.up * 0.2f);
        }
    }
    */
    public void StopMoving()
    {
        //moveLeft = false;
        //moveRight = false;
        moveUp = false;
        audio.Stop();
        mainEngineParticles.Stop();
        //rigidBody.velocity = Vector3.zero;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (state != State.Alive || collisionAreDisabled) { return; }

        switch (collision.gameObject.tag)
        {
            case "Friendly":
                break;
            case "Finish":
                StopMoving();
                StartSuccessSequence();
                break;
            default:
                life = life - 1;
                break;



        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "star")
        {
            scoreText.text = (int.Parse(scoreText.text) + 5).ToString();
            Destroy(col.gameObject);
        }
        if (col.tag == "life")
        {
            if (life == 3)
            {
                Destroy(col.gameObject);
            }
            else if (life < 3)
            {
                life = life + 1;
                Destroy(col.gameObject);
            }
        }
        
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

        UIHandler.instance.ShowLevelDialog("Level Cleared", scoreText.text);
        Debug.Log("Score", scoreText);
        //Invoke("LoadNextScene", levelLoadDelay); //Paramaterise this time
    }

    private void StartDeathSequence()
    {
       state = State.Dying;
       StopMoving();
       // audio.Stop();
       // audio.PlayOneShot(deathSound);
       // if (!deathSoundParticles.isPlaying)
       // {
       //     deathSoundParticles.Play();
       //     
       // }
       // audio.Stop();
        //Invoke("LoadCurrentScene", levelLoadDelay);
        UIHandler.instance.ShowLevelDialogFailed(); 
    }
    private void LoadFirstLevel()
    {
        SceneManager.LoadScene(0);
    }
    private void OnParticleCollision(GameObject other)
    {
        life = life - 1;
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
