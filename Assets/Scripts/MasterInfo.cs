using UnityEngine;

public class MasterInfo : MonoBehaviour
{

    public static int coinCount = 0;
    public static int gemCount = 0;
    public static int distanceRun;
    [SerializeField] int internalDistance;

    [SerializeField] GameObject coinDisplay;
    [SerializeField] GameObject gemDisplay;
    [SerializeField] GameObject runDisplay;

    void Start()
    {
        coinCount = 0;
        distanceRun = 0;
        gemCount = 0;
    }

    
    void Update()
    {
        internalDistance = distanceRun;
        coinDisplay.GetComponent<TMPro.TMP_Text>().text = "" + coinCount;
        gemDisplay.GetComponent<TMPro.TMP_Text>().text = "" + gemCount;
        runDisplay.GetComponent<TMPro.TMP_Text>().text = "" + distanceRun;
    

    }
}
