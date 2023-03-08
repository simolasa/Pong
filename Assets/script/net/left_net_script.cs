using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_net : MonoBehaviour
{
    public Logic_script ls;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ls.addScore(1);
    }
}
