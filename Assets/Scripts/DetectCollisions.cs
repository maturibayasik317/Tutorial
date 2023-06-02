using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    [SerializeField] int point;
    [SerializeField] int scoreValue;
    [SerializeField] GameObject effectPrefab;
    [SerializeField] int objectHP;
    [SerializeField] ScoreManager sm;
    [SerializeField] GameObject[] animalprefabs;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("animalPrefabs")) 
        {
            objectHP -= 1;

            if(objectHP > 0) 
            {
                Destroy(other.gameObject);//‚Ô‚Â‚©‚Á‚½‘Šèiotherj‚ğÁ‚·
                GameObject effect = Instantiate(effectPrefab, transform. position, Quaternion.identity);
                Destroy(effectPrefab,2.0f);
            }
            else 
            {
                Destroy(other.gameObject);
                GameObject effect = Instantiate(effectPrefab,transform.position,Quaternion.identity);
                Destroy(effect,2.0f);
                Destroy(this.gameObject);
            }

        }

    }

    void Start() 
    {
        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    }  
