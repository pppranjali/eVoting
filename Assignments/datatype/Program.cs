int num1= 2;
static int fact(int num)
{
    if(num>0)
        return(num* fact(num-1));
    else
    {
        return 1;
    }
}
Console.WriteLine(fact(num1) );
