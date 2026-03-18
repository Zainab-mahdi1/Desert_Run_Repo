using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public static int loadedCoin;
    public static int loadedGem;
    public static int loadedDistance;
    public static bool saveData;
    [SerializeField] int internalCoin;
    [SerializeField] int internalGem;
    [SerializeField] int internalDistance;
    void Start()
    {
        loadedCoin = PlayerPrefs.GetInt("COINSAVE");
        loadedGem = PlayerPrefs.GetInt("GEMSAVE");
        loadedDistance = PlayerPrefs.GetInt("DISTANCESAVE");
    }

    void Update()
    {
        internalCoin = loadedCoin + MasterInfo.coinCount;
        internalDistance = loadedDistance + MasterInfo.distanceRun;
        internalGem = loadedGem + MasterInfo.gemCount;
        
        if(saveData == true)
        {
            saveData = false;
            PlayerPrefs.SetInt("COINSAVE", internalCoin);
            PlayerPrefs.SetInt("GEMSAVE", internalGem);
            PlayerPrefs.SetInt("DISTANCESAVE", internalDistance);

        }
    }
}
