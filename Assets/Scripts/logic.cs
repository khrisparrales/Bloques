using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logic : MonoBehaviour

{
    public float velocidad = 18f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tecladoh = Input.GetAxisRaw("Horizontal");
        float positionx = transform.position.x + (tecladoh*velocidad*Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp( positionx,-5,5), transform.position.y, transform.position.z);
        
        //float mouseh = Input.GetAxisRaw("Mouse X");
    }
}
