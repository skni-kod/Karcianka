using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Loader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public void loadScene(int sceneId)
    {
        StartCoroutine(LoadAsynchronously(sceneId));
    }

    IEnumerator LoadAsynchronously(int sceneId)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progrss = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progrss;
            yield return null;
        }
    }
}
