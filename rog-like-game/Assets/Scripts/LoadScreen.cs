using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class LoadScreen : MonoBehaviour
{
    public Slider progressBar;
    public void Load(int start)
    {
        StartCoroutine(startLoading(start));
    }

    IEnumerator startLoading(int start)
    {
        yield return new WaitForSeconds(2);
        AsyncOperation async = SceneManager.LoadSceneAsync(start);
        while (!async.isDone)
        {
            progressBar.value = async.progress;
            yield return null;
        }

       
    }
}
