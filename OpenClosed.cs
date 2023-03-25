public class OpenClosedPrincipleExample
    {
        public void Run()
        {
            InputReader reader = new InputReader();
            OutputWriter writer = new OutputWriter();
            int choice = 0;
            IAnimal animal;

            writer.Write("Options");
            writer.Write("1 - Dog");
            writer.Write("2 - Cat");
            writer.Write("3 - Cow");
            writer.Write("Choose an animal: ");
            choice = reader.ReadInt32();

            switch (choice)
            {
                case 1:
                    animal = new Dog();
                    break;
                case 2:
                    animal = new Cat();
                    break;
                case 3:
                    animal = new Cow();
                    break;

                default:
                    animal = new Dog();
                    break;
            }

            writer.Write(animal.MakeSound());
        }
    }

    public interface IAnimal
    {
        public string MakeSound();
    }

    public class Dog : IAnimal
    {
        public string MakeSound()
        {
            return "Bark";
        }
    }

    public class Cat : IAnimal
    {
        public string MakeSound()
        {
            return "Meow";
        }
    }

    public class Cow : IAnimal
    {
        public string MakeSound()
        {
            return "Moo";
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