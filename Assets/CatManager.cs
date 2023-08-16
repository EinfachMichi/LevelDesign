using System;
using UnityEngine;

public class CatManager : MonoBehaviour
{
   public static CatManager Instance;
   
   public int currentState;

   public GameObject cat;
   public Animator catAnim;

   private void Awake()
   {
      Instance = this;
   }

   public void TriggerCat()
   {
      cat.gameObject.SetActive(true);
      currentState++;

      switch(currentState)
      {
         case 1:
            catAnim.SetTrigger("Trigger1");
            break;
         case 2:
            catAnim.SetTrigger("Trigger2");
            break;
         case 3:
            catAnim.SetTrigger("Trigger3");
            break;
      }
   }
}