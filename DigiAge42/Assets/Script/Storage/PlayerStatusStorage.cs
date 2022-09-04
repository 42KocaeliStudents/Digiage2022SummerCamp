using Assets.Script.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Storage
{
    [CreateAssetMenu(menuName = "Storage/Scriptable Object PlayerStatus", fileName = "Scriptable Object PlayerStatus", order = 0)]
    public class PlayerStatusStorage : ScriptableObject
    {
        public float Healty { get => healty; set => healty = value; }
        public float Energy { get => energy; set => energy = value; }
        public int Level { get => level; set => level = value; }

        public float healty;
        public float energy;
        public int level;
        private void Awake()
        {
            Debug.Log("Monobehaviour da bulunduğu gibi awake fonksiyonu scriptable objelerde de bulunmaktadır.");
            Debug.Log("Awake sadece editörde çalışır");
        }

        private void OnEnable()
        {
            Debug.Log("OnEnable fonksiyonu scriptable objelerde de bulunmaktadır.");
            Debug.Log("OnEnable hem editörde hem de run time da çalışmaktadır.");
        }

        private void OnDisable()
        {
            Debug.Log("OnDisable fonksiyonu scriptable objelerde de bulunmaktadır.");

        }
    }
}
