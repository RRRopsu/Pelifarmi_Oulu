using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleExplosion : MonoBehaviour
{
    public float rate = 0.1f;
    public AudioClip explosion;

    ParticleSystem particle;
    float timer;
    AudioSource audio;

    private void Start()
    {
        particle = gameObject.GetComponent<ParticleSystem>();
        audio = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            if (timer > rate)
            {
                particle.Emit(1);
                timer = 0;
            }
        }
    }

    void OnParticleCollision(GameObject col)
    {
        Camera.main.GetComponent<ScreenShake>().ShakeScreen();
        audio.pitch = Random.Range(0.90f, 1.10f);
        audio.PlayOneShot(explosion, Random.Range(0.2f, 0.4f));
    }
}
