using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] public GameObject loadScreen;
    [SerializeField] public Slider slider;
  //  [SerializeField] public Text loadText;
    bool isLoading;
    public void LoadLevel(string level)
    {
        // StartCoroutine(LoadAsync(level));
        StartCoroutine(AsynchronousLoad(level));

    }

    /*  IEnumerator LoadAsync(string levelName)
      {
          AsyncOperation operation = SceneManager.LoadSceneAsync(levelName);
          loadScreen.SetActive(true);
          while (!operation.isDone)
          {
              float progress = Mathf.Clamp01(operation.progress / .9f);
              slider.value = progress;
              loadText.text = progress * 100f + "%";
              yield return new WaitForSeconds(0.1f);
          }
      }*/
    private IEnumerator AsynchronousLoad(string scene)
    {
        isLoading = true;

        AsyncOperation _asyncOp = SceneManager.LoadSceneAsync(scene);
        _asyncOp.allowSceneActivation = false;
        while (!_asyncOp.isDone)
        {
            float progress = Mathf.Clamp01(_asyncOp.progress / .9f);
            slider.value = progress;
            //loadText.text = progress * 100f + "%";
            if (Mathf.Approximately(_asyncOp.progress, 0.9f))
            {
                _asyncOp.allowSceneActivation = true;
     
            }
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForEndOfFrame();
        isLoading = false;
        yield return null;
    }
}
