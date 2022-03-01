// See https://aka.ms/new-console-template for more information
int i =0;
//create array to sort
int[] evenNums;
evenNums= new int[5]{2, 1, 5, 3, 12};

int n = evenNums.Length;
int change;

while(n>1)
{
    for(i=0; i<n-1; i++)
    {
        if(evenNums[i]>evenNums[i+1])
        {
            change=evenNums[i+1];
            evenNums[i+1]=evenNums[i];
            evenNums[i]=change;
        }
    }
    n=n-1;
}
// print array sorted
foreach (int s in evenNums)
    {
        Console.Write("\t{0}", s);   
    }

