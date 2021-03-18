using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipScript : MonoBehaviour
{
    public void DisplayTooltip()
    {
        gameObject.GetComponent<Animator>().SetTrigger("displayTooltip");
    }
}
