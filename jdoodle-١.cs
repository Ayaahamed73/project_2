using System;

class Program
{
    static void Main(string[]args) {
        Console.WriteLine("please entre n1");
        int n1=int.Parse(Console.ReadLine() );
        Console.WriteLine("please entre n2");
        int n2=int.Parse(Console.ReadLine() );
        
        int i ,j ;
        for( i=n1;i<=n2;i++)
        {
            int sum=0;
        
            j=1;
            while(j<i)
            {
                if(i%j==0)
           sum=sum+j;
           j++;
            }
            
            if(sum==i)
            Console.WriteLine(i);
        }
        Console.ReadKey();
}

}