using UnityEngine.UI;
using UnityEngine;

public class bestScore : MonoBehaviour
{
    public static int apple;
    public Text Count;
    void Start()
    {
        Count = GetComponent<Text>();
       
        PlayerPrefs.SetInt("Score", Apple.apple);
    }

    
    void Update()
    {
        
        Count.text = "лучший счет : " + PlayerPrefs.GetInt("Score");
    }
}
