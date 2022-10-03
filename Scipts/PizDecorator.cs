using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class PizDecorator : Piz
{
    protected Piz m_Pizza;

    public PizDecorator(Piz pizza)
    {
        this.m_Pizza = pizza;
    }

    public virtual float GetPrice()
    {
        return this.m_Pizza.GetPrice();
    }

    public virtual float GetEnergy()
    {
        return this.m_Pizza.GetEnergy();
    }
}


public class WithExtraCheese : PizDecorator
{
    float m_Price = 20.0f;
    float m_Energy = 400f;

    public WithExtraCheese(Piz pizza) : base(pizza)
    {
    }

    public override float GetPrice()
    {
        return base.GetPrice() + m_Price;
    }
    public override float GetEnergy()
    {
        return base.GetEnergy() + m_Energy;
    }
}

public class WithTomato : PizDecorator
{
    float m_Price = 1f;
    float m_Energy = 130f;

    public WithTomato(Piz pizza) : base(pizza)
    {

    }

    public override float GetPrice()
    {
        return base.GetPrice() + m_Price;
    }
    public override float GetEnergy()
    {
        return base.GetEnergy() + m_Energy;
    }
}

public class WithPeperoni : PizDecorator
{
    float m_Price = 4f;
    float m_Energy = 600f;

    public WithPeperoni(Piz pizza) : base(pizza)
    {
    }

    public override float GetPrice()
    {
        return base.GetPrice() + m_Price;
    }
    public override float GetEnergy()
    {
        return base.GetEnergy() + m_Energy;
    }
}

public class WithChicken : PizDecorator
{
    float m_Price = 2.5f;
    float m_Energy = 300f;

    public WithChicken(Piz pizza) : base(pizza)
    {
    }

    public override float GetPrice()
    {
        return base.GetPrice() + m_Price;
    }
    public override float GetEnergy()
    {
        return base.GetEnergy() + m_Energy;
    }
}

public class WithAllIn : PizDecorator
{
    float m_Price = 2.5f;
    float m_Energy = 300f;

    public WithAllIn(Piz pizza) : base(pizza)
    {
    }

    public override float GetPrice()
    {
        return base.GetPrice() + m_Price;
    }
    public override float GetEnergy()
    {
        return base.GetEnergy() + m_Energy;
    }
}