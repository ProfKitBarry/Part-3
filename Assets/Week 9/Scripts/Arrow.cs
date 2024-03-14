using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 5f;
    public Transform theif;
    public Transform knife;
    float speed1 = 1;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(this.gameObject, theif.position * speed1* Time.deltaTime , knife.rotation);
        }
 
    }
}
