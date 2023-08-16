using UnityEngine;

public class CatTrigger : MonoBehaviour
{
   public GameObject cat;
   public Animator catAnim;

   private void OnTriggerEnter(Collider other)
   {
      cat.SetActive(true);
      catAnim.SetTrigger("Trigger");
      Destroy(gameObject);
   }
}
