using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    // Растояние от камеры до объекта 
    private Vector3 offset;
    //Объект, за которым будет следить
    public GameObject target;
	// Use this for initialization
	void Start () {
        offset = target.transform.position - transform.position;

     	}
	
	// Update is called once per frame
	void Update () {
    transform.position = target.transform.position - offset;


    }
}
