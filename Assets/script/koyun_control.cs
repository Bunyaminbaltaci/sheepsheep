using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;



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
    public bool pausecheck1;
    



    public bool IsPointerOverGameObject(int fingerId)
    {
        EventSystem eventSystem = EventSystem.current;
        return (eventSystem.IsPointerOverGameObject(fingerId)
            && eventSystem.currentSelectedGameObject != null);
    }




    void Start()
    {
        koyun_fizik = GetComponent<Rigidbody2D>();
        koyun_alan = GetComponent<Collider2D>();
        animasyon_kont = GetComponent<Animator>();
        Time.timeScale = 1;
        pausecheck1 = false;


    }

    // Update is called once per frame
    void Update()
    {
      
        ziplamakontrol = Physics2D.IsTouchingLayers(koyun_alan, zeminkontrol);
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {

           
            if (IsPointerOverGameObject(Input.GetTouch(0).fingerId))
            {
               
            }
            else
            {
               
               


                if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) && pausecheck1==false)
                {


                    if (ziplamakontrol == true)
                    {
                        FindObjectOfType<audio>().Play("playerjump");
                        koyun_fizik.velocity = new Vector2(koyun_fizik.velocity.x, jumpforce);
                        ziplamakontrol = false;
                    }

                }

                

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
