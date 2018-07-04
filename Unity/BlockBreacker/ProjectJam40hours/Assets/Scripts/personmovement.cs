using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personmovement : MonoBehaviour {

    private personmovement person;
    int xmin = -6;
    int xmax = 7;
    int x = 0;
    int y = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 10.0f;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 10.0f;

       
        transform.Translate(x, y, 0);
       



        /* if (Input.GetKeyUp("w"))
         {
             print("yoyoyo");
             this.transform.position = new Vector3(x,++y, 0);
             print(this.transform.position);
         }else 
             if (Input.GetKeyDown("s"))
             {
                 print("yoyoyo");
                 this.transform.position = new Vector3(x, --y, 0);
                 print(this.transform.position);
             }else 
                 if (Input.GetKeyDown(KeyCode.A))
                 {
                     print("yoyoyo");
                     this.transform.position = new Vector3(--x, y, 0);
                     print(this.transform.position);
                 }
                 else if (Input.GetKeyDown(KeyCode.D)) {
                     this.transform.position = new Vector3(++x, y, 0);
                     print(this.transform.position);
                 }*/
    }
}