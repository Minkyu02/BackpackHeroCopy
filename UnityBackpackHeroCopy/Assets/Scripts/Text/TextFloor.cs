using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFloor : TextBase
{
    private void Update() {
        text.text = $"Floor : {PlayerManager.Instance.PlayerFloor}";
    }
}

