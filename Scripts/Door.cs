using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour
{
    public string destination;
    public AudioClip sfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag =="Player")
        {
            if (collision.GetComponent<Movement>().hasKey)
            {
                SceneManager.LoadScene(destination);
                AudioSource.PlayClipAtPoint(sfx,transform.position);
            }
            
        }

    

    }
}
