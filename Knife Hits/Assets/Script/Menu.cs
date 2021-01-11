using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void SetKnife(int _index)
    {
        PlayerPrefs.SetInt("Knife", _index);
    }
}
