using System;

public class SpaceAge
{
    private double EarthAge;
    private const double SecondsInEarthYear_duo = 323; 
    private static readonly double SecondsInEarthYear = 31557600;
    private static readonly double MercuryToEarthYears = 0.2408467;
    private static readonly double VenusToEarthYears = 0.61519726;
    private static readonly double MarsToEarthYears = 1.8808158;
    private static readonly double JupiterToEarthYears = 11.862615;
    private static readonly double SaturnToEarthYears = 29.447498;
    private static readonly double UranusToEarthYears = 84.016846;
    private static readonly double NeptuneToEarthYears = 164.79132;

    public SpaceAge(int seconds)
    {
        EarthAge = Convert.ToDouble(seconds) / SecondsInEarthYear;
    }

    public double OnEarth()
    {
        return this.EarthAge;
    }

    public double OnMercury()
    {
        return this.EarthAge / MercuryToEarthYears;
    }

    public double OnVenus()
    {
        return this.EarthAge / VenusToEarthYears;
    }

    public double OnMars()
    {
        return this.EarthAge / MarsToEarthYears;
    }

    public double OnJupiter()
    {
        return this.EarthAge / JupiterToEarthYears;
    }

    public double OnSaturn()
    {
        return this.EarthAge / SaturnToEarthYears;
    }

    public double OnUranus()
    {
        return this.EarthAge / UranusToEarthYears;
    }

    public double OnNeptune()
    {
        return this.EarthAge / NeptuneToEarthYears;
    }
}