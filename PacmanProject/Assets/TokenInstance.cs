using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenInstance : MonoBehaviour
{
    void OnPlayerEnter(CharacterController player) {
        Score.instance.AddPoint();
    }

}
