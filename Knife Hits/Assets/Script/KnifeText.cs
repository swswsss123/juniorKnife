using UnityEngine.UI;
using UnityEngine;

public class KnifeText : MonoBehaviour
{
    public static int knifes;
    public Text Knifetext;

    void Start()
    {
        Knifetext = GetComponent<Text>();
        knifes = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Knifetext.text = "X" + KnifeSpowner.throws;


    }
}


