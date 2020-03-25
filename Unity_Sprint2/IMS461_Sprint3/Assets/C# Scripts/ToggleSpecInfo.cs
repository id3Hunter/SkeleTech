using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSpecInfo : MonoBehaviour
{
    public GameObject info;

    private void Start()
    {
        info = GameObject.Find("SpecInfo");
        info.SetActive(false);
        if (info) { Debug.Log("Spec was found."); }
    }
    public void ToggleInfo()
    {
        
        if (info.activeSelf == true) { info.SetActive(false); } else { info.SetActive(true); }

    }
}
