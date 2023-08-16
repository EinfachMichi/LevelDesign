using System;
using UnityEngine;

namespace DefaultNamespace
{
   public class PlayerManager : MonoBehaviour
   {
      public bool HasKey;
      public LayerMask doorLayer;

      private void Update()
      {
         if(Input.GetKeyDown(KeyCode.F) && NearDoor(out Door door))
         {
            if(HasKey)
            {
               door.OpenDoor();
            }
         }
      }

      private bool NearDoor(out Door door)
      {
         Collider[] cols = Physics.OverlapSphere(
                     transform.position,
                     0.5f,
                     doorLayer
         );
         door = cols[0].GetComponentInParent<Door>();

         if(cols != null) return true;
         return false;
      }

      private void OnTriggerEnter(Collider other)
      {
         if(other.CompareTag("Key"))
         {
            HasKey = true;
            Destroy(other.gameObject);
         }
      }
   }
}