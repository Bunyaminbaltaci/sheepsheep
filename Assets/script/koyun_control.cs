using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class koyun_control : MonoBehaviour
{
    public bool isdead;
    public float jumpforce;
    private Rigidbody2D koyun_fizik;
    public bool ziplamakontrol;
    public LayerMask zeminkontrol;
    private Collider2D koyun_alan;
    private Animator animasyon_kont;
    public game_manager manager;
    public GameObject deathscreen;
    public GameObject pausescreen;
    
  
  
    



    void Start()
    {
        koyun_fizik = GetComponent<Rigidbody2D>();
        koyun_alan = GetComponent<Collider2D>();
        animasyon_kont = GetComponent<Animator>();
        Time.timeScale = 1;
       

       
    }

    // Update is called once per frame
    void Update()
    {
  
        ziplamakontrol = Physics2D.IsTouchingLayers(koyun_alan, zeminkontrol);


        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) )
        {


            if (ziplamakontrol == true)
            {
                FindObjectOfType<audio>().Play("playerjump");
                koyun_fizik.velocity = new Vector2(koyun_fizik.velocity.x, jumpforce);
                ziplamakontrol = false;
            }

        }

        animasyon_kont.SetBool("ziplamakontrol", ziplamakontrol);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="pointarea")
        {
            FindObjectOfType<audio>().Play("point");
            manager.updatescore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="deatharea")
        {
            isdead = true;
            animasyon_kont.SetBool("carpmakontrol", isdead);
            animasyon_kont.SetBool("baslangickontrol", false);
            FindObjectOfType<audio>().Play("playerdeath");
            StartCoroutine(animasyonubekle());
                       

            


        }
        IEnumerator animasyonubekle()
        {

            yield return new WaitForSecondsRealtime(1f);
            Time.timeScale = 0;
            pausescreen.SetActive(false);
            deathscreen.SetActive(true);
          
            
        }
    }






}
