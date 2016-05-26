using UnityEngine;
using System.Collections;

namespace GnG {
    public enum Effects { Damage, Heal };
    public class Casting : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        static void ExeCast(Spell_ spell)
        {
            for (int i = 0; i < spell.Effects.Length; i++)
            {
                EffectSelect(spell.Effects[i]);
            }
        }

        static void EffectSelect(Effects effect)
        {
            switch (effect)
            {
                case Effects.Damage: /*get targets*/ /*call TakeDamage() for Each*/; Debug.Log("Caused Damage"); break;
                case Effects.Heal: /*get tagets*/ /*call Heal() for Each*/; Debug.Log("Healed"); break;

            }
        }
    }
    }