using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GerakanPlayer : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    Animator animator;

    public Transform playerTrans;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Gerak();
    }

    void Gerak()
    {
        float gerak = Input.GetAxis("Horizontal");

        rb.velocity = Vector3.right * gerak * speed;
        animator.SetFloat("Kecepatan", Mathf.Abs(gerak), .1f, Time.deltaTime);

        playerTrans.localEulerAngles = new Vector3(0, gerak * 90, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("virus"))
        {
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}
