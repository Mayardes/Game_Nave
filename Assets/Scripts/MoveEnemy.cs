using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MoveEnemy : MonoBehaviour {

    public float speed;

    //// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0, 1) * speed * Time.deltaTime;

         if(transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.name == "Square" && gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            PlayerPrefs.SetInt("score", 0);
        }

        if(collider.tag == "Shoot")
        {
            Destroy(gameObject);
            Destroy(collider.gameObject);

            //Começa a contar a pontuação
            //PlayerPrefs uma variável que fica mesmo depois que reiniciamos o aparelho
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
            if(PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore", PlayerPrefs.GetInt("score"));
            }
        }
    }
}
