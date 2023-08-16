using System;
using UnityEngine;

namespace DefaultNamespace
{
   public class DoorTrigger : MonoBehaviour
   {

      public Door door;
      private void OnTriggerEnter(Collider other)
      {
         if(!other.CompareTag("Player")) return;
         
         door.OpenDoor();
      }
   }
}