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
        public bool StartTime;
        public float cooldown;
        public float seconds = 3;


        private void Start()
        {
            SpawnEnemies();
            StartTime = false;
        }
        private void Update()
        {
            if (EnemyDisabled() <= 0 && !StartTime)
            {
                StartTime = true;
                cooldown = Time.time;
                // Start counter
            }
            if(StartTime && Time.time >= cooldown + seconds)
            {
                StartTime = false;
                Respawn();
            }
            else
            {
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
                GameObject enemy = Instantiate(enemylist[i], patrolPoint[i].position, Quaternion.identity);
                enemy.GetComponent<EnemyController>().enabled = true;
                enemy.transform.parent = this.transform;


                ActiveEnemys.Add(enemy);
               



                
            }
        }
        public void Respawn()
        {
            for (int i = 0; i < ActiveEnemys.Count; i++)
            {
                ActiveEnemys[i].SetActive(true);
                ActiveEnemys[i].GetComponent<EnemyController>().statemachine.Intialize(ActiveEnemys[i].GetComponent<EnemyController>().patrol_State);
                ActiveEnemys[i].transform.position = patrolPoint[i].position;
            }
        }
        public int EnemyDisabled()
        {
            int p = 0;
            for (int i = 0; i < ActiveEnemys.Count; i++)
            {
                if (ActiveEnemys[i].activeInHierarchy)
                {
                    p++;
                    if(p >= 2)
                    {
                        return p;
                    }
                    
                }
            }
            return 0;
        }
        private Transform SetPatrolPoint1()
        {

            return patrolPoint[0];
        }
        private Transform SetPatrolPoint2()
        {

            return patrolPoint[1];
        }
        
        public void RemoveEnemy(GameObject obj)
        {
            if (ActiveEnemys.Contains(obj))
            {
                ActiveEnemys.Remove(obj);
            }
        }

    }
}
