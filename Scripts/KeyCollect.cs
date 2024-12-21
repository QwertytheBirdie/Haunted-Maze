using UnityEngine;
using UnityEngine.Audio;
public class KeyCollect : MonoBehaviour
{
    public string destination;
    private AudioSource keySound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        keySound = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            GetComponentInChildren<SpriteRenderer>().enabled = true;
            keySound.Play();

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {

            GetComponentInChildren<SpriteRenderer>().enabled = false;
        }
    }


    // public void OnCollisionEnter2D(Collision2D collision)
    //  {
    // if(collision.gameObject.tag == "Key")
    //  {
    //  keySound.Play();
    //   }
    // }
}

