using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makers : MonoBehaviour
{
    public GameObject thing;
    List<Tings> thingList = new List<Tings>();
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(thing);
            thingList.Add(go.GetComponent<Tings>());
        }
        foreach(Tings thing in thingList)
        {
            Debug.Log(thing.ToString()+""+Tings.nu);
        }
    }
}
