using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exeO1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);
        //basique mouvement de l'objet
    }

    // Update is called once per frame
    void Update()
    {
        //affichage de la postion de l'objet dans la console
        Debug.LogWarning(transform.position);
    }

}
