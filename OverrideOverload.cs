public class OverrideOverload
{
    public void Run()
    {
        InputReader reader = new InputReader();
        OutputWriter writer = new OutputWriter();
    }

    // method override
    // method overload
    // polymorphism
    // inheritance
    // composition


    // parent - base class - superclass
    public class Animal{
        public string Name {get;set;} = string.Empty;
        public int Age {get;set;} = 0;

        public Animal(){

        }

        public virtual string MakeSound(){
            return "Animal Souond";
        }
    }

    // override
    public class Dog: Animal{
        

        public override string MakeSound()
        {
            return "override Dog";
        }
    }

    // overload
    public class Cat: Animal{
        public string MakeSound(string sound){
            return sound;
        }
    }
}