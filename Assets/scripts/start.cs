using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class start : MonoBehaviour {
	
		
		// a public variable is exposed to the inspector and might be changed
		public float speed = 2f;
		
		
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {

			// move hand
			if (Input.GetKey (KeyCode.D)) {
				transform.position += new Vector3 (-1f, 0f, 0f) * Time.deltaTime * speed;
			}

			
		}
	}
