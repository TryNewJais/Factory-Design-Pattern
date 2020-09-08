using System;

namespace Design_Pattern
{
    /*
     * Factory is a object creation pattern which is mostly used when we don't know which object will get created at the begining, and there is multiple possiable object that could get created. This different from builder as factory creation of object is not partial. 
      -> so, basically we have a switch which gives us  which object we need, and obviously we need an superclass/abstract  class for this.
      -> will ave an interface of objectCreator and and class that implements.  
      
     */
    /*
     Example : we need multiple type to write a file. 
     */

   


    public interface IWriterFactory
    {
      void parse(string[] input);
    }

    public abstract class AbstractWritter
    {
    public abstract IWriterFactory GetWritter(string type);
    }

    public class WritterA : IWriterFactory
    {
        public void parse(string[] input)
        {
            Console.WriteLine("WritterA");
        }
    }
    public class WritterB : IWriterFactory
    {
        public void parse(string[] input)
        {
            Console.WriteLine("WritterB");
        }
    }

    public class WriterFactory : AbstractWritter
    {
        public override IWriterFactory GetWritter(string type)
        {
            IWriterFactory abstractWritter = null;
            switch (type)
            {
                case "A":
                    abstractWritter = new WritterA();
                    break;
                case "B":
                    abstractWritter = new WritterB();
                    break;
            }
            return abstractWritter;
        }
    }

    public class Caller
    {
        public Caller()
        {
            AbstractWritter abstractWritter = new WriterFactory();
            IWriterFactory writer = abstractWritter.GetWritter("A");
            writer.parse(new string[] { });
        }

    }

}
