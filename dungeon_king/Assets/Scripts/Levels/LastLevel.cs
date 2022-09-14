using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastLevel : MonoBehaviour
{
    private GameObject lastLevel;
    [SerializeField] private Uncle uncle;
    // Start is called before the first frame update
    void Start()
    {   
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (uncle.playerHealth.isDead())
            gameObject.SetActive(true);
    }
}
