# Unity-2D-Platformer-Game-Basics
2D Platformer Controller scripts for unity C#
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class karakterkonrol : MonoBehaviour

{

Rigidbody2D rb2;

float horizontal;

public float karakterhiz;

bool yerde = true;

public float ziplamahiz;

// Start is called before the first frame update

void Start()

{

rb2 = gameObject.GetComponent<Rigidbody2D>();

}

// Update is called once per frame

void Update(){

if (Input.GetKeyDown(KeyCode.Space) && (yerde == true)) {

rb2.AddForce(new Vector2(0,ziplamahiz));

yerde = false;

}

if (Mathf.Approximately(rb2.velocity.y, 0)){

yerde = true;

}

}

void FixedUpdate()

{

horizontal = Input.GetAxisRaw("Horizontal");

rb2.velocity = new Vector3(horizontal * Time.deltaTime * karakterhiz,rb2.velocity.y,0);

}

/*private void OnCollisionEnter2D(Collision2D collision){

if(collision.gameObject.tag == "zemin"){

yerde = true;

}

}*/

}
