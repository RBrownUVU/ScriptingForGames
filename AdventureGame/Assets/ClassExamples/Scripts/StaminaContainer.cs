using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaContainer : MonoBehaviour
{
    public SimpleFloatData staminaData;
    
    public void ReduceStamina(float amount)
    {
        staminaData.UpdateValue(amount);
    }
}