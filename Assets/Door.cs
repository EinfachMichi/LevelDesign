using System;
using UnityEngine;

public class Door : MonoBehaviour
{
   private Animator anim;
   private bool open;

   private void Awake()
   {
      anim = GetComponent<Animator>();
   }

   public void OpenDoor()
   {
      if(open) return;

      open = true;
      anim.SetTrigger("Open");
   }
}
