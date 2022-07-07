using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScore : MonoBehaviour
{
    public AudioClip coinSound;
    public GameHandler GH;
    // Start is called before the first frame update
    void Start()
    {
        GH = GameObject.Find("Speedometer").GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Vehicle") { 
        GH.coins++;
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        Destroy(gameObject);
        Debug.Log("Coins: " + GH.coins);
        }
    }
}
