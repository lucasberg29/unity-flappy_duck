using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckHero : MonoBehaviour
{
    private AddToScore scoreScript;

    public Rigidbody2D rigidBody2D;
    public float yForce;

    public AudioSource wingSound;
    public AudioSource hitSound;

    public EagleParallax eagle1;
    public EagleParallax eagle2;
    public EagleParallax eagle3;
    public EagleParallax eagle4;

    public Vector2 duckPosition;

    public WaveParallax wave;

    private GameObject canvas;

    private Animator duckAnimator;

    // Start is called before the first frame update
    void Start()
    {
        duckAnimator = GetComponent<Animator>();
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        scoreScript = GameObject.FindGameObjectWithTag("Score").GetComponent<AddToScore>();

        duckPosition = transform.position;
        Vector2 forceToAdd = new Vector2(0.0f, yForce);
        rigidBody2D.AddForce(forceToAdd);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (GameManager.Instance.GetIsPaused())
            {
                GameManager.Instance.ResumeGame();
                canvas.GetComponent<CanvasManager>().ResumeGame();
            }
            else
            {
                if ( duckAnimator.GetBool("IsFlapping"))
                {
                    duckAnimator.Play("WingFlap");
                }
                else
                {
                    duckAnimator.SetBool("IsFlapping", true);
                }

                Vector2 forceToAdd = new Vector2(0.0f, yForce);
                wingSound.Play();
                rigidBody2D.AddForce(forceToAdd);

            }
        }

        if(transform.position.y >= 4.7f)
        {
            hitSound.Play();

            eagle1.ResetPosition();
            eagle2.ResetPosition();
            eagle3.ResetPosition();
            eagle4.ResetPosition();
            wave.RefreshPosition();

            rigidBody2D.velocity = new Vector2(0.0f, 5.0f);

            transform.position = duckPosition;

            canvas.GetComponent<CanvasManager>().GameOver();
            scoreScript.ResetScore();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hitSound.Play();

        eagle1.ResetPosition();
        eagle2.ResetPosition();
        eagle3.ResetPosition();
        eagle4.ResetPosition();
        wave.RefreshPosition();

        rigidBody2D.velocity = new Vector2(0.0f, 5.0f);

        transform.position = duckPosition;

        canvas.GetComponent<CanvasManager>().GameOver();
        scoreScript.ResetScore();
    }

}
