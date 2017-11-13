using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

    public float speed;
    public float limitX, limitY;
    public GameObject projectile;
    public AudioSource SomNave;
    public AudioClip Som;
    

    // Use this for initialization

    // Update is called once per frame
    void Update() {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;

        if (transform.position.x > limitX)
        {
            transform.position = new Vector3(limitX, transform.position.y);
        }
        if (transform.position.x < -limitX)
        {
            transform.position = new Vector3(-limitX, transform.position.y);
        }

        //Posição Y Axis
        if (transform.position.y > limitY)
        {
            transform.position = new Vector3(transform.position.x, limitY);
        }
        if (transform.position.y < -limitY)
        {
            transform.position = new Vector3(transform.position.x, -limitY);
        }

        if(Input.GetKeyDown("space"))
        {
            Shoot(gameObject); //Passando o jogador como parâmetro
            
        }

    }
        void Shoot(GameObject player)
    {
       
        //Instantiate(projectile); //*passa como parâmetro o jogador
        GameObject shoot = Instantiate(projectile, new Vector3(player.transform.position.x, player.transform.position.y + 1), transform.rotation) as GameObject;
        SomNave.PlayOneShot(Som, 1f);
        }


    }


