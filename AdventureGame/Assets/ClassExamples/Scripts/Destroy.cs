using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private Collider myCollider;
    private SpriteRenderer mySprite;
    void Start()
    {
       myCollider = GetComponent<Collider>();
       mySprite = GetComponent<SpriteRenderer>();
    }
    public void OnTriggerEnter(Collider other)
    {
        Destroy(myCollider);
        Destroy(mySprite);
        Destroy(gameObject, 2f);
    }
  
}
