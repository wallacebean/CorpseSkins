using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;
using UnityEngine;
using GameplayEntities;
using Debug = UnityEngine.Debug; // ADDED this line as well 

namespace corpseskins
{
    [BepInPlugin("us.wallace.plugins.llb.corpseskins", "Corpse Skins Plug-In", "1.0.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Debug.Log("Patching effects settings...");

            var harmony = new Harmony("org.bepinex.plugins.exampleplugin");
            harmony.PatchAll();
        }
    }
    [HarmonyPatch(typeof(CorpseEntity), nameof(CorpseEntity.SetCharacter))]
    class CorpsePatch
    {
		static bool Prefix(CorpseEntity __instance, Character setCharacter, CharacterVariant variant)
		{
			//code goes here, use __instance to access the instance of corpse entity 
			
			{
				__instance.character = setCharacter;
				if (variant == CharacterVariant.ALT0)
				{
					variant = CharacterVariant.ALT0;
				}
				else if (variant == CharacterVariant.ALT1)
				{
					variant = CharacterVariant.ALT1;
				}
				else if (variant == CharacterVariant.ALT2)
				{
					variant = CharacterVariant.ALT2;
				}
				else if (variant == CharacterVariant.ALT3)
				{
					variant = CharacterVariant.ALT3;
				}
				else if (variant == CharacterVariant.ALT4)
				{
					variant = CharacterVariant.ALT4;
				}
				else if (variant == CharacterVariant.ALT5)
				{
					variant = CharacterVariant.ALT5;
				}
				else if (variant == CharacterVariant.ALT6)
				{
					variant = CharacterVariant.ALT6;
				}
				else if (variant == CharacterVariant.MODEL_ALT)
				{
					variant = CharacterVariant.MODEL_ALT;
				}
				else if (variant == CharacterVariant.MODEL_ALT2)
				{
					variant = CharacterVariant.MODEL_ALT2;
				}
				else if (variant == CharacterVariant.MODEL_ALT3)
				{
					variant = CharacterVariant.MODEL_ALT3;
				}
				else if (variant == CharacterVariant.MODEL_ALT4)
				{
					variant = CharacterVariant.MODEL_ALT4;
				}
				else if (variant == CharacterVariant._MAX)
				{
					variant = CharacterVariant._MAX;
				}
				AOOJOMIECLD modelValues = JPLELOFJOOH.NEBGBODHHCG(__instance.character, variant);
				__instance.standardScale = modelValues.OGMOEKPOBBP;
				__instance.SetVisualModel("main", modelValues, false, false);
				__instance.AddClipsToAnimInfo();
				if (setCharacter != Character.KID && setCharacter != Character.CANDY)
				{
					__instance.SetAnimInfo("knockback", HHBCPNCDNDH.NKKIFJJEPOL(1.0m), false, string.Empty, 0f, false);
				}
				__instance.DisableEffectGameObjects();
			}

			return false;
        }
    }
}

