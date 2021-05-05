using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pelota : MonoBehaviour
{
    public float velocidadi = 600f;
    Rigidbody rb;
    bool enjuego;
    Transform barra;
    Vector3 posicioninicial;

    void Awake() {
        rb = GetComponent<Rigidbody>();
        barra = GetComponentInParent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        posicioninicial = transform.position;
    }
    public void reset()
    {
        transform.position = posicioninicial;
        transform.SetParent(barra);
        enjuego = false;
        DetenerMovi();
    }
    public void DetenerMovi()
    {
        rb.isKinematic = true;

        rb.velocity = Vector3.zero;
    }
    // Update is called once per frame
    void Update()
    {
        if (!enjuego&& Input.GetButtonDown("Fire1"))
        {
            enjuego = true;
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce(new Vector3(velocidadi,velocidadi,0));
        }
        
    }
}
