using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float waitTime = 2f;
    [SerializeField] ParticleSystem finishEffect;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            finishEffect.Play();
            Invoke("ReloadScene", waitTime);
        }
    }
    void ReloadScene() 
    {
        SceneManager.LoadScene(0);
    }
}