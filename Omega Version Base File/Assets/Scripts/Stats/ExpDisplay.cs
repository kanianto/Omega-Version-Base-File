using UnityEngine;
using UnityEngine.UI;
using System;

namespace Omega.Stats
{
    public class ExpDisplay : MonoBehaviour
    {
        Experience experience;

        private void Awake()
        { 
            experience = GameObject.FindWithTag("Player").GetComponent<Experience>();
        }

        private void Update()
        {
            GetComponent<Text>().text = String.Format("{0:0}", experience.GetPoints());
        }
    }
}