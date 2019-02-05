using System;

public class SpaceAge
{
    private double EarthAge;

    public SpaceAge(int seconds)
    {
        EarthAge = Convert.ToDouble(seconds) / 31557600;
    }

    public double OnEarth()
    {
        return this.EarthAge;
    }

    public double OnMercury()
    {
        return this.EarthAge / 0.2408467;
    }

    public double OnVenus()
    {
        return this.EarthAge / 0.61519726;
    }

    public double OnMars()
    {
        return this.EarthAge / 1.8808158;
    }

    public double OnJupiter()
    {
        return this.EarthAge / 11.862615;
    }

    public double OnSaturn()
    {
        return this.EarthAge / 29.447498;
    }

    public double OnUranus()
    {
        return this.EarthAge / 84.016846;
    }

    public double OnNeptune()
    {
        return this.EarthAge / 164.79132;
    }
}