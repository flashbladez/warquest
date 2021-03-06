﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarQuest.Characters
{
    [CreateAssetMenu(menuName = "RPG/ArmourSlot/HeadSlot")]

    public class HeadSlotConfig : ScriptableObject
    {
        public Transform goToAttachToTransform;
        [SerializeField] HeadSlotConfig headSlot;
        [SerializeField] GameObject armorPrefab;
        [SerializeField] string objectName;
        [SerializeField] float staminaValue;
        [SerializeField] float mentalAgilityValue;
        [SerializeField] float energyValue;
        [SerializeField] float strengthValue;
        [SerializeField] float hitValue;
        [SerializeField] float armourValue;

        public HeadSlotConfig HeadSlot()
        {
            return headSlot;
        }

        public GameObject GetArmourPrefab()
        {
            return armorPrefab;
        }

        public string GetObjectName()
        {
            return objectName;
        }

        public float GetStamina()
        {

            return staminaValue;
        }

        public float GetMentalAgility()
        {
            return mentalAgilityValue;
        }

        public float GetEnergy()
        {
            return energyValue;
        }

        public float GetStrength()
        {
            return strengthValue;
        }

        public float GetHit()
        {
            return hitValue;
        }

        public float GetArmourValue()
        {
            return armourValue;
        }

    }
}
