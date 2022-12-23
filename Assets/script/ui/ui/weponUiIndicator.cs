using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class weponUiIndicator : MonoBehaviour
    {
        public Transform planel1;
        public Transform Panel2;
        public WeponUiEvent wepon;
        // Start is called before the first frame update
        void Start()
        {
            InitalizeWepon(0);
            wepon.OnWeaponChange += InitalizeWepon;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void InitalizeWepon(int i)
        {
            if(i == 1)
            {
                planel1.SetAsFirstSibling();
            }
            else
            {
                Panel2.SetAsFirstSibling();
            }
        }
    }
}
