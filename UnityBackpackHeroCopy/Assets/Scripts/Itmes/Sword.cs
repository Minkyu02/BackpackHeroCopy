using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sword : Item
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        itemSize[1].GetComponent<Image>().enabled = true;
        itemSize[4].GetComponent<Image>().enabled = true;
        itemSize[7].GetComponent<Image>().enabled = true;

        itemActive.Add(itemSize[1]);
        itemActive.Add(itemSize[4]);
        itemActive.Add(itemSize[7]);
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
