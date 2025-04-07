using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WednesdayAttach : MonoBehaviour
{
   public void OnTriggerEnter(Collider other)
   {
      transform.parent = other.transform;  
   }
   
   public void OnTriggerExit(Collider other)
   {
      transform.parent = null;
   }
}
