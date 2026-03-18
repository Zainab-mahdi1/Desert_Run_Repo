using System.Collections;
#if UNITY_EDITOR
using TMPro.EditorUtilities;
using UnityEditor;
using UnityEditor.ShaderKeywordFilter;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuControl : MonoBehaviour
{
    [SerializeField] GameObject fadeOut;
    [SerializeField] AudioSource buttonSelect;

    [SerializeField] int loadedCoin;
    [SerializeField] int loadedGem;
    [SerializeField] int loadedDistance;
    [SerializeField] GameObject coinDisplay;
    [SerializeField] GameObject gemDisplay;
    [SerializeField] GameObject distanceDisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(LoadData());
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void StartGame()
    {

        StartCoroutine(StartButton());
    }

    IEnumerator StartButton()
    {
        buttonSelect.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);

    }

    IEnumerator LoadData()
    {
        yield return new WaitForSeconds(0.05f);
        loadedCoin = PlayerPrefs.GetInt("COINSAVE");
        loadedGem = PlayerPrefs.GetInt("GEMSAVE");
        loadedDistance = PlayerPrefs.GetInt("DISTANCESAVE");
        coinDisplay.GetComponent<TMPro.TMP_Text>().text = "" + loadedCoin;
        gemDisplay.GetComponent<TMPro.TMP_Text>().text = "" + loadedGem;
        distanceDisplay.GetComponent<TMPro.TMP_Text>().text = "" + loadedDistance;
    }

}
