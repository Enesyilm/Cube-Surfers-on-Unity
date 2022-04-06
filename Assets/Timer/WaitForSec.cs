using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForSec
{
    float secondCounter=0;
   public  bool WaitForSecond(float second){
      
      secondCounter+=Time.deltaTime;
      if(secondCounter>=second)
      {
          
          return true;
      }
      return false;

   }
   private void Update() {
       Debug.Log("Waitforsec update working");
   }
}
