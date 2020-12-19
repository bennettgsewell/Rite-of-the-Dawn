//Written by Bennett Sewell
//Parallax script for the background stuff

using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Parallax : MonoBehaviour {
    public float mult = 1f;
    public float midPoint = 0f;
    public float farPoint = 5f;
    public Transform ground;
    public Transform targetPivot;
    public Transform[] parObjects;
    float x;
    public void Update()
    {
        foreach (Transform t in parObjects)
        x = (targetPivot.position.x - midPoint) / farPoint;
        foreach (Transform t in parObjects)
        {
            t.localScale = new Vector3(Mathf.Abs(t.position.z), Mathf.Abs(t.position.z), 1f);
            t.position = new Vector3(midPoint + x * mult * t.position.z * -1f, t.position.y, t.position.z);
        }
    }

    public void OnGUI()
    {
        Update();
    }
}
