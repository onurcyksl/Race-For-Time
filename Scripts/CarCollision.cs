using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    [SerializeField] ParticleSystem rockParticle;
    [SerializeField] ParticleSystem treeParticle;
    [SerializeField] ParticleSystem explosionParticle;

    public AudioSource audioSource;
    public GameHandler GH;
    void Start()
    {
        GH = GameObject.Find("Speedometer").GetComponent<GameHandler>();
    }

    private void OnCollisionEnter(Collision collision)
    {


        if(collision.gameObject.tag == "Rock")
        {
            Debug.Log("Rock");
            rockParticle.Play();
        }
        if (collision.gameObject.tag == ("Wood"))
        {
            Debug.Log("Wood");
            treeParticle.Play();
       
        }
 
        if (collision.gameObject.tag == "Cars")
        {
            Debug.Log("Cars");
            
            if(GH.coins != 0)
            {
                GH.coins--;
            }
            explosionParticle.Play();
            audioSource.Play();
            Debug.Log("Score: " + GH.coins);
        }

    }
}
