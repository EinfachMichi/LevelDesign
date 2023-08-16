using DefaultNamespace;
using UnityEngine;

public class Candle : MonoBehaviour
{
   public GameObject[] lights;

   public CatTrigger trigger;
   
   private void OnTriggerEnter(Collider other)
   {
      if(!other.CompareTag("Player")) return;
      
      if(trigger != null) trigger.Trigger();

      foreach(GameObject o in lights)
      {
         o.SetActive(true);
      }
      Destroy(gameObject);
   }
}
