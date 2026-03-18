using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadToStage : MonoBehaviour
{
    [SerializeField] GameObject FadeOut;

    void Start()
    {
       StartCoroutine(Loadlevel()); 
    }

    IEnumerator Loadlevel()
    {
        yield return new WaitForSeconds(2);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);

    }
}
