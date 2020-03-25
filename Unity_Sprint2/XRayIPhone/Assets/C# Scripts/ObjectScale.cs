using UnityEngine;
using System.Collections;
using Vuforia;

public class ObjectScale : MonoBehaviour
{
    void OnMouseDown()
    {
        CSharpScaling.ScaleTransform = this.transform;
    }
}
