using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem crushEffect;
    [SerializeField] AudioClip crashSFX;
    bool  hasCrashed = false;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            crushEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }
    }

    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
