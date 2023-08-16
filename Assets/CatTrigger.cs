using System;
using UnityEngine;

namespace DefaultNamespace
{
   public class CatTrigger : MonoBehaviour
   {
      public bool requirement;
      
      private void OnTriggerEnter(Collider other)
      {
         if(requirement || !other.CompareTag("Player")) return;
         
         CatManager.Instance.TriggerCat();
         Destroy(gameObject);
      }

      public void Trigger()
      {
         requirement = false;
      }
   }
}