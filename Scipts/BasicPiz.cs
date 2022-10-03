using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPiz : Piz
{
    float m_BasicPrice = 7.0f;
    float m_BasicEnergy = 600.0f;

    public float GetPrice()
    {
        return m_BasicPrice;
    }

    public float GetEnergy()
    {
        return m_BasicEnergy;
    }
}
