using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOutImage : MonoBehaviour
{
    public Image image;

    public void FadeInFunction()
    {
        StartCoroutine(FadeImage(false));
    }

    public void FadeOutFunction()
    {
        StartCoroutine(FadeImage(true));
    }

    IEnumerator FadeImage(bool fadeAway)
    {
        if (fadeAway)
        {
            for (float i = 1.5f; i >= 0; i -= Time.deltaTime)
            {
                image.color = new Color(0, 0, 0, i);
                yield return null;
            }
        }
        else
        {
            for (float i = 0; i <= 1.5f; i += Time.deltaTime)
            {
                image.color = new Color(0, 0, 0, i);
                yield return null;
            }
        }
    }
}
