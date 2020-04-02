using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{

    Coroutine routine;
    float startFov = 0;
    private void Start()
    {
        startFov = Camera.main.fieldOfView;
    }

    public void ShakeScreen()
    {
        if (routine != null)
        {
            StopCoroutine(routine);
        }
        Camera.main.fieldOfView = startFov;
        routine = StartCoroutine(Shake());
    }

    IEnumerator Shake()
    {
        float t = 0;
        float size = Camera.main.fieldOfView;
        Camera.main.fieldOfView -= 1.5f;

        while (t < 0.6f)
        {
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, size, 5 * Time.deltaTime);
            t += Time.deltaTime;
            yield return null;
        }
        Camera.main.fieldOfView = size;
        yield return null;
    }
}
