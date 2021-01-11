using UnityEngine.UI;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static int apple;
    public Text appleCount;
    void Start()
    {
        appleCount = GetComponent<Text>();
        apple = 0;
        if (apple > Knife.best_score)
        {
            PlayerPrefs.SetInt("Score", Knife.best_score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        appleCount.text = "X"; 
    }
}
