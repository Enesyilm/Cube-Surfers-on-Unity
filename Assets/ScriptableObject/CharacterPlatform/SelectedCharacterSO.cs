using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "SelectedCharacterSO", menuName = "Cube Surfers/SelectedCharacterSO", order = 0)]
public class SelectedCharacterSO : ScriptableObject{
    [SerializeField]
    private CharacterSO selectedCharacter;

    public CharacterSO SelectedCharacter { get => selectedCharacter; set {
        selectedCharacter = value;
    
    } }
}
