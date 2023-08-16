using UnityEngine;

namespace DefaultNamespace
{
   public class Cat : MonoBehaviour
   {
      public void Die()
      {
         Destroy(gameObject);
      }

      public void Disable()
      {
         gameObject.SetActive(false);
      }
   }
}