using UnityEngine;
using TMPro;
using System.Collections;

public class BlinkingText : MonoBehaviour
{
    public TextMeshProUGUI text;
    private float duration = 1.2f;
    private float maxAlpha = 1f;
    private float minAlpha = 0f;

    private void Start()
    {
        StartCoroutine(Blink());
    }
    private void Awake()
    {
        StartCoroutine(Blink());
    }
    private IEnumerator Blink()
    {
        if (text != null) {
            while (true)
            {
                float t = 0;
                while (t < duration)
                {
                    t += Time.deltaTime;
                    text.alpha = Mathf.Lerp(maxAlpha, minAlpha, t / duration);
                    yield return null;
                }
                yield return new WaitForSeconds(0.2f);
                t = 0;
                while (t < duration)
                {
                    t += Time.deltaTime;
                    text.alpha = Mathf.Lerp(minAlpha, maxAlpha, t / duration);
                    yield return null;
                }
                yield return new WaitForSeconds(0.2f);
            }
        }

    }
}
