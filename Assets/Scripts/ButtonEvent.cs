using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
   public GameManager gameManager;
   protected Button button;

   public void Start()
   {
      button = GetComponent<Button>();
   }

   public virtual void ButtonOnClick()
   {
      
   }
}
