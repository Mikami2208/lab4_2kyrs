using System.Numerics;

namespace lab4_2kyrs;

public class Frac : IMyNumber<Frac>
{
    private BigInteger _nom, _denom;

    public  Frac(BigInteger nom, BigInteger denom)
    {
        if (denom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        
        if (denom < 0)
        {
            nom = -nom;
            denom = -denom;
        }
        var gcd = GCD(BigInteger.Abs(nom), BigInteger.Abs(denom));
        _nom = nom / gcd;
        _denom = denom/ gcd;
    }
    
    private static BigInteger GCD(BigInteger a, BigInteger b)
    {
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public override string ToString()
    {
        return $"{_nom}/{_denom}";
    }

      public Frac Add(Frac that)
    {
        return new Frac(_denom * that._nom + that._denom * _nom, _denom * that._denom);
    }
    
    public Frac Subtract(Frac that)
    {
        return new Frac(that._denom * _nom - _denom * that._nom, _denom * that._denom);
    }

    public Frac Multiply(Frac that)
    {
        return new Frac(_nom * that._nom, _denom * that._denom);
    }

    public Frac Divide(Frac that)
    {
        return new Frac(_nom * that._denom, _denom * that._nom);
    }   
}