using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codecamera : MonoBehaviour
{

    public GameObject a;

    private Vector3 b;


    void LateUpdate()
    {
        transform.position = a.transform.position + b;
    }

    // Start is called before the first frame update
    void Start()
    {
        b = transform.position - a.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = a.transform.position + b;
    }


}
