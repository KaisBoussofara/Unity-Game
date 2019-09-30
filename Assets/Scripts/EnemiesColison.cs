using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesColison : MonoBehaviour
{ // EnemiesColison  & HealthSystem 
    [SerializeField] GameObject Explosion;
    [SerializeField] Transform Postion;
    [SerializeField] int Hits = 4;
    [SerializeField] int Score = 12;
    ScoreDisplay ScoreB;
    private void Start()
    {
        ScoreB = FindObjectOfType<ScoreDisplay>();
    }
    private void OnParticleCollision(GameObject other)
    {
        ScoreB.ScoreRecord(Score);
        Hits--; 
        if (Hits <= 1)
        {

            KillEnemy();
        }

    }

    private void KillEnemy()
    {
        GameObject Explose = Instantiate(Explosion, transform.position, Quaternion.identity);
        Explose.transform.parent = Postion;
        Destroy(gameObject);
    }
}
