using System.Numerics;

namespace lab4_2kyrs;

public class MyComplex : IMyNumber<MyComplex>
{
    private double _re;
    private double _im;

    public MyComplex(double ex1, double ex2)
    {
        _re = ex1;
        _im = ex2;
    }

    public MyComplex Add(MyComplex that)
    {
        return new MyComplex(_re + that._re, _im + that._im);
    }

    public MyComplex Subtract(MyComplex that)
    {
        return new MyComplex(_re - that._re, _im - that._im);
    }
    
    public MyComplex Multiply(MyComplex that)
    {
        return new MyComplex(_re*that._re - _im*that._im, _re*that._im + _im*that._re);
    }
    
    public MyComplex Divide(MyComplex that)
    {
        return new MyComplex((_re*that._re + _im*that._im)/(Math.Pow(that._re, 2) + Math.Pow(that._im, 2)), 
            (_im*that._re - _re*that._im)/(Math.Pow(that._re, 2) + Math.Pow(that._im, 2)));
    }

    public override string ToString()
    {
        return $"{_re}+{_im}i";
    }
}