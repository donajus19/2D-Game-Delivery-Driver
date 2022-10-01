using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] float destroyDelay = 0.2f;
    bool hasPackage;
    SpriteRenderer spriterRenderer;

    private void Start() {
      spriterRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
        
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
          if(other.tag == "Package" && !hasPackage)
          {
            Debug.Log("Package picked up!");
            hasPackage = true;
            spriterRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);

          }
          if(other.tag == "Customer" && hasPackage)
          {
            Debug.Log("Package Delivered!");
            spriterRenderer.color = noPackageColor;
            hasPackage = false;
          }
    }
}
