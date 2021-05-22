using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFracture : MonoBehaviour
{
   [SerializeField] private GameObject fracturedVersion;

   // destroy mesh and instance new gameobject if other.tag == player
   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
      {
          GetComponent<Collider>().enabled = false;
          Instantiate(fracturedVersion, transform.position, Quaternion.identity);
          Destroy(gameObject);
      }
   }
}
