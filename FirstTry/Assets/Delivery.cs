using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour{

    bool PackeStuvation;
    [SerializeField] float destroyTime = 0.5f;
    [SerializeField] Color32 packageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 nopackageColor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && PackeStuvation==false)
        {
            PackeStuvation = true;
            spriteRenderer.color = packageColor;     
            Destroy(other.gameObject, destroyTime);

            
        }
        if (other.tag == "Customer" && PackeStuvation==true)
        {
            PackeStuvation = false;
            spriteRenderer.color = nopackageColor;
            Destroy(other.gameObject, destroyTime);

        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");

    }
}
