using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning2 : MonoBehaviour
{
    private AudioSource playSound;

    private void OnTriggerEnter(Collider other)
    {
        playSound.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        playSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
