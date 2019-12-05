using System.Collections.Generic;

namespace Trestlebridge.Interfaces
{
    //when we use <T> we are using a generic type parameter
    /*
    In a generic type or method definition, a type parameter is a placeholder for a specific type that a client specifies when they create an 
    instance of the generic type. A generic class, such as GenericList<T> listed in Introduction to Generics, cannot be used as-is because it 
    is not really a type; it is more like a blueprint for a type. To use GenericList<T>, client code must declare and instantiate a constructed 
    type by specifying a type argument inside the angle brackets. The type argument for this particular class can be any type recognized by 
    the compiler
    */
    public interface IFacility<T>
    {
        double Capacity { get; }

        //we use void when it doesn't return anything
        void AddResource(T resource);
        void AddResource(List<T> resources);
    }
}