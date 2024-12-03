namespace lab4_2kyrs;

public interface IMyNumber<T> where T: IMyNumber<T>
{
    T Add(T that);
    T Subtract(T that);
    T Multiply(T that);
    T Divide(T that);
}

