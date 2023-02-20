using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLevel : TextBase
{
    private void Update() {
        text.text = $"Level : {PlayerManager.Instance.playerExp} / {PlayerManager.Instance.playerNextExp}";
    }
}
