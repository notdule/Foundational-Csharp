// For statement

using System.Runtime.InteropServices;

string[] bigBrands = {"Nike", "Adidas", "Dior", "Puma", "New Balance"};

for (int i = 0; i < bigBrands.Length; i+=2 )
{
    Console.WriteLine(bigBrands[i]);
}

string[] capitalCities = {"Paris", "Madrid", "Belgrade", "Sarajevo", "Berlin"};

foreach (string capitalCity in capitalCities)
{
    Console.WriteLine(capitalCity);
}

int[] numbers = {1, 2, 3, 7, 8, 11, 12, 13, 19};
int primeNumbers = 0;
int notPrimeEnergyNumbers = 0;

foreach (int number in numbers)
{
    if (number / 2 == 1)
    {
        primeNumbers++;
    }
    else if (number / 2 != 1)
    {
        notPrimeEnergyNumbers++;
    }

}
    Console.WriteLine($"There is {primeNumbers} Prime (*not energy*) Numbers");
    Console.WriteLine($"There is {notPrimeEnergyNumbers} dumb numbers :(");