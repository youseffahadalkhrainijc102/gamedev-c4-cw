using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rocket : MonoBehaviour {


    Rigidbody rocketRB;
    AudioSource rocketAudioSource;
    int loadingTime = 2;
    bool isControlEnabled = true;
    [SerializeField] AudioClip mainEngine;
    [SerializeField] float thrustSpeed = 5.0f;
    [SerializeField] float rotationSpeed = 2.5f;
    [SerializeField] GameObject winningFX;
    [SerializeField] GameObject expo;
    // Start is called before the first frame update
    void Start()
    {
        rocketRB = GetComponent<Rigidbody>();
        rocketAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isControlEnabled) {
            Rotate();
            thurst();
        }
       
    }


        void Rotate()
        {
            if (Input.GetKey(KeyCode.A))
            {
                print("Rotate right");
            transform.Rotate(Vector3.forward);
            }
            else if (Input.GetKey(KeyCode.D))
            {
            print("Rotate left");
             transform.Rotate(-Vector3.forward * rotationSpeed);
        }
        }

    void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);
        switch (collision.gameObject.tag) {

            case "Freindly":
                print("no proplem");
                    break;

            case "Finish":
                print("you win!!!");
                // LoadNextScene() ;
                Invoke("LoadNextScene", loadingTime);
                isControlEnabled = false;
                winningFX.SetActive(true);
                    break;

                default:
                print("you lose ");
                //SceneManager.LoadScene(0);
                Invoke("LoadFirstLevel", loadingTime);
                isControlEnabled = false;
                expo.SetActive(true);
                    break;
                }

    }
    void LoadFirstLevel()
    {
        SceneManager.LoadScene(0);
    }

    void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextsceneIndex = currentSceneIndex + 1;
        if (nextsceneIndex == SceneManager.sceneCountInBuildSettings)
        {

            nextsceneIndex = 0;
        }
        SceneManager.LoadScene(nextsceneIndex);

    }

    void thurst()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            print("Thursting");
            rocketRB.AddRelativeForce(Vector3.up * thrustSpeed);
            rocketAudioSource.PlayOneShot(mainEngine);
        }
    }

}