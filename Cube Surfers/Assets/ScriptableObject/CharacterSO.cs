﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterSO", menuName = "Cube Surfers/CharacterSO", order = 0)]
public class CharacterSO : ScriptableObject{
[SerializeField]
public GameObject characterModel;
[SerializeField]
public String characterName;
[SerializeField]
public int price;
    [SerializeField]
    private bool isLocked;

    public bool IsLocked { get => isLocked; set{ isLocked = value;
    EditorUtility.SetDirty(this);} }
}
