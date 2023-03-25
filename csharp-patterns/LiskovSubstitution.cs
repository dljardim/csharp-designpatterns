namespace LiscovSubstitution{

public class LiscovSubstitutionExample
{
    public void Run(){
        InputReader reader = new InputReader();
        OutputWriter writer = new OutputWriter();

        List<Animal> animals = new List<Animal>(){
            new Lion(), new Tiger(), new Bear(), new Elephant()
        };

        foreach (Animal animal in animals)
        {
            writer.Write(animal.MakeSound());
        }
    }
}


public class Animal{
    public virtual string MakeSound(){
        return "ANIMALSOUND";
    }
}

public class Lion : Animal
{
    public override string MakeSound()
    {
        return "LIONSOUND";
    }
}

public class Tiger : Animal
{
    public override string MakeSound()
    {
        return "TIGERSOUND";
    }
}

public class Bear : Animal
{
    public override string MakeSound()
    {
        return "BEARSOUND";
    }
}

public class Elephant : Animal
{
    public override string MakeSound()
    {
        return "ELEPHANTNOISE";
    }
}

public class InputReader
    {
        public int ReadInt32()
        {
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
    }

    public class OutputWriter
    {
        public void Write(string output)
        {
            Console.WriteLine(output);
        }
    }
}

/*
public class LiscovSubstitutionExample
{
    
}

public class Animal{
    public string MakeSound(){
        return "ANIMALSOUND";
    }
}

public class Lion
{
    public string MakeSound()
    {
        return "LIONSOUND";
    }
}

public class Tiger
{
    public string MakeSound()
    {
        return "TIGERSOUND";
    }
}

public class Bear
{
    public string MakeSound()
    {
        return "BEARSOUND";
    }
}

public class Elephant
{
    public string MakeSound()
    {
        return "ELEPHANTNOISE";
    }
}


// public class LiscovSubstitution
// {
//     public void Run()
//     {
//         var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

//         SumCalculator sum = new SumCalculator(numbers);
//         SumCalculator sum2 = new EvenNumbersSumCalculator(numbers);

//         EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);

//         // liscov substitution principle says if we replace our superclass with a subclass - 
//         // output should not be changed

//         Console.WriteLine("");
//         Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}"); // 18
//         Console.WriteLine($"The sum of all the numbers (using subclass): {sum2.Calculate()}"); // 18

//         Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}"); // 40
//     }
// }


// public class SumCalculator
// {
//     protected readonly int[] _numbers;

//     public SumCalculator(int[] numbers)
//     {
//         _numbers = numbers;
//     }

//     public virtual int Calculate() => _numbers.Sum();
// }

// public class EvenNumbersSumCalculator : SumCalculator
// {
//     public EvenNumbersSumCalculator(int[] numbers)
//         : base(numbers)
//     {
//     }

//     public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
// }

// /*
// Liscov substitution - 

// sumcalculator class with has an array of numbers
// - this class will sum all values in the array

// now we need
// a class that will sum all the odd numbers of the array
// a class that will sum all the even numbers of the array


// class containing an array

// */