using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A location on a character to attach equipment (like hand, head, feet, ...)
/// </summary>

public class EquipAttach : MonoBehaviour
{

    //장비를 붙이다
    public EquipSlot slot;
    public EquipSide side;

    public Transform[] childs;

}
