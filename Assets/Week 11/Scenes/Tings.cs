using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tings : MonoBehaviour
{

    public static float nu;
    public float nub;
    // Start is called before the first frame update
    void Start()
    {
        nu = Random.Range(0, 10);
        nub = Random.Range(0, 10);
        Debug.Log(this.ToString() + "static: " + nu + "non-static:" + nub);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
