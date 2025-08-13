using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float waitTime = 0.5f;
    [SerializeField] ParticleSystem CrashEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            CrashEffect.Play();
            Invoke("ReloadScene", waitTime);

        }
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
