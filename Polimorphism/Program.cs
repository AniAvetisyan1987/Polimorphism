using Polimorphism;

internal class Program
{
    private static void Main(string[] args)
    {
        //Animal animal = new Animal();
        //Dog dog = new Dog();
        //Cat cat = new Cat();

        //animal.AnimalSound();
        //dog.AnimalSound();
        //cat.AnimalSound();

        //A a = new A();
        //a.Method();
        //a.StandardMethod();

        //B b = new B();
        //b.Method();
        //b.StandardMethod();

        A c = new B();
        c.Method();
        c.StandardMethod();

        Animal animal = new Animal();
        Cat cat = new Cat();
        Dog dog = new Dog();
        Bird bird = new Bird();

        Animal cat2 = new Cat();
        cat.Life();
        cat2.Life();

        cat.Body();
        cat2.Body();
        Console.WriteLine("////////////////////////////////////////////");
        dog.Body();
        bird.Body();


    }
}