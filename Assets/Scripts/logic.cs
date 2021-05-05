using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logic : MonoBehaviour

{
  
    Vector3 posicioninicial;

    // Start is called before the first frame update
    void Start()
    {
        posicioninicial = transform.position;
    }
    public void reset()
    {
        transform.position = posicioninicial;
    }

    // Update is called once per frame
    void Update()
    {
         
        //float mouseh = Input.GetAxisRaw("Mouse X");
    }
}
