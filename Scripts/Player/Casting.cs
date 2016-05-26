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

//precast will load information and initialize targeting
   public static void PreCast(Spell_ spell)
   {
       this.spell = spell;
       this.Caster = spell.Caster;
       this.targeting = Caster.Targeting;
       this.effects = spell.Effects;
 
       //set up targeting
         //instantiate a prefabed targeting format which contains an opaque 3D image and colider and attach it to the player
         Caster.Targeting = targeting;
         //this object will actively keep track of which targets are in the area and return them in an array (targets) to be used later
       //remain in precasting state until the spell is cast than switch to whilecasting state
   }
 
//whileCasting will remove the targeting and call the ExeEffect() as needed to ensure each enemy within the space is being effected correctly
   public static WhileCasting()
   {
       //deavtivate the targeting object from the player
       //ensure the spell effects each of the targets within the area of effect for the spell
       for(int i = 0; i < targets.Length; i++)
       {
          CurrentTarget = targets[i];
            CurTrgtHealth = CurrentTarget.GetComponent<Attributes>().Health;
            CurTrgtEnergy = CurrentTarget.GetComponent<Attributes>().Energy;
            CurTrgtRigidBody = CurrentTarget.GetComponent<RigidBody>();
            /*add others as needed*/
          ExeEffect();
       }
   }
//all exe. code for abilities
   public static void ExeEffect()
   {
       for(int i = 0; i < Effects.Length; i++)
       {
          //switch statement with Exe Code of spell components, combine different compnents to create different spells
          switch(effects[i])
          {
            case enum.Damage:   CurTrgtHealth -= spell.Power * 3; /*Play audio, show animation/partical effect etc... here*/ break;
           
            case enum.Heal:     CurTrgtHealth += spell.Power * 2; /*Play audio, show animation/partical effect etc... here*/ break;
          }
       }
   }
}
 
//Spell_'s will be prefabed and loaded into an array for access
    }
    }
