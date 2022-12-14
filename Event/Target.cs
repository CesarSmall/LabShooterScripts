using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //Les References vers le script "TargetCounter"
    [SerializeField] GameObject HolderReference;
    TargetCounter targetCounter;


    private void Awake()
    { //Donne acces aux contenus de la classe "TargetCounter"
        targetCounter = HolderReference.GetComponent<TargetCounter>();
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet")){
            // +1 au TargetCounter
            Debug.Log("Hit");
            targetCounter.Counter++;
            Destroy(this.gameObject);
        }
    }
}
