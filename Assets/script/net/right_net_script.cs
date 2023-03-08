using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class right_net_script : MonoBehaviour
{
    public Logic_script ls;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ls.addScore(2);   
    }
}
