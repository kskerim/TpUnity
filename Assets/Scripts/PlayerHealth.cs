using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxLifePoints = 3;

    public int currentLifePoints;

    public bool isInvulnerable = false;

    public SpriteRenderer sr;

    public float invulnerableDuration = 3;

    public float invulnerableDelta = 0.15f;

    public HealtBar healthBar

    // Start is called before the first frame update
    void Start()
    {
        currentLifePoints = maxLifePoints;
    }

    public void Hurt(int damage) 
    {
        if(!isInvulnerable) {
            healthBar.Fill(   )
            currentLifePoints = currentLifePoints - damage;
            StartCoroutine(Invulnerable());
        }
    }

    public IEnumerator Invulnerable() { //IEnumerator permet de mettre des pauses dans le code (yield) "StartCoroutine"
        isInvulnerable = true;

        WaitForSeconds invulnerableDeltaWait = new WaitForSeconds(invulnerableDelta);

        for (float i = 0; i <= invulnerableDuration; i += invulnerableDelta) {
            if(sr.color.a == 1) {
                sr.color = new Color(1f, 1f, 1f, 0f);
            } else {
                sr.color = Color.white;
            }

            yield return invulnerableDeltaWait; //le yield permet au code d'attendre
        }

        sr.color = Color.white;
        isInvulnerable =  false;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentLifePoints == 0) {
            Destroy(gameObject);
        }

    }
}