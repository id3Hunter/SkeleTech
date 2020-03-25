using UnityEngine;
using System.Collections;

public class ObjectRotate : MonoBehaviour
{

    public GameObject layer1;
    public GameObject layer2;
    public GameObject layer3;


    private void Start()
    {
        layer1 = GameObject.Find("layer1");
        layer2 = GameObject.Find("layer2");
        layer3 = GameObject.Find("layer3");
    }
    public void ToggleInfo(GameObject layer)
    {
        if (layer.activeSelf == true) { layer.SetActive(false); } else { layer.SetActive(true); }
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 20 * Time.deltaTime, 0);
        //Keep track of taps on screen
        int numOfTaps = 0;
        foreach (Touch touch in Input.touches)
        {
            numOfTaps++;
            if (numOfTaps >= 2) {

            }
                
        }
    }
}
