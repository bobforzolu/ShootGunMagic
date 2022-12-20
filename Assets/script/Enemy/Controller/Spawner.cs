using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField]private List<GameObject> ActiveEnemys;
        [SerializeField]private GameObject[] enemylist;
        [SerializeField]private int _MaxSpawn = 2;
        [SerializeField]private Transform[] patrolPoint;


        private void Start()
        {
            SpawnEnemies();
        }
        private void Update()
        {
            if(ActiveEnemys.Count <= 0)
            {
               // Start counter
            }
        }
        private void SpawnEnemies()
        {
            for (int i = 0; i < _MaxSpawn; i++)
            {
                if ( i == 0)
                {
                    enemylist[i].GetComponent<EnemyController>().PatrolPoint[0] = SetPatrolPoint1();

                    enemylist[i].GetComponent<EnemyController>().PatrolPoint[1] = SetPatrolPoint2();

                }
                else if(i == 1)
                {
                    enemylist[i].GetComponent<EnemyController>().PatrolPoint[0] = SetPatrolPoint2();

                    enemylist[i].GetComponent<EnemyController>().PatrolPoint[1] = SetPatrolPoint1();
                }
                GameObject enemy =  Instantiate(enemylist[i], patrolPoint[i].position, Quaternion.identity);
                enemy.GetComponent<EnemyController>().enabled = true;
                enemy.transform.parent = this.transform;


                ActiveEnemys.Add(enemy);
               



                
            }
        }
        private Transform SetPatrolPoint1()
        {

            return patrolPoint[0];
        }
        private Transform SetPatrolPoint2()
        {

            return patrolPoint[1];
        }

    }
}
