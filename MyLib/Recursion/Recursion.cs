namespace MyLib;

public class Recursion
{
    public int Factorial(int n)
    {
        if (n < 0)
            return n;
        else if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }


    public int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }


    public int Power(int x, int n)
    {
        if (n == 0)
            return 1;

        return x * Power(x, n - 1);
    }


    public int Print(int n)
    {
        if (n == 0)
            return 1;
        return Print(n - 1);
    }

    ///sum(n/10)+n%10;
    //Count(n/10) + 1;
    //mul(n-1)+M
    //sa=couint0(n/10); if(n%10 == 0){sa+1}else{sa} 
}