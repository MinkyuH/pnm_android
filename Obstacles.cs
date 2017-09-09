using UnityEngine;
using System.Collections;

public class Obstacles : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<UserScripttwo>() != null)
        {
            GameController.instance.Score();
        }
    }
}