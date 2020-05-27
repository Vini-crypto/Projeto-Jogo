using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto1 : MonoBehaviour
{
	public GameObject numeros;
	public Text texto;
	private GameObject conta;

	// Start is called before the first frame update
	void Start()
	{
		texto.enabled = false;
		conta = GameObject.FindWithTag("Player");
	}

// Update is called once per frame
	void Update()
	{
		if (Vector3.Distance(transform.position, conta.transform.position) < 2)
		{
			texto.enabled = true;
		}
		else
		{
			texto.enabled = false;
		}
	}


}	
