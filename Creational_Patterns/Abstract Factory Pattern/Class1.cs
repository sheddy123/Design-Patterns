using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Patterns.Abstract_Factory_Pattern
{
    /*
     * ABSTRACT FACTORY DESIGN
     * The abstract factory pattern provides a way to encapsulate a group of individual factories that have a common
     * theme without specifying their concrete classes
     * 
     * The abstract factory pattern provides an interface for creating famlies of related or dependent
     * objects without specifying their concrete classes
     * 
     * Abstract Factory pattern belongs to creational patterns and is one of the most used
     * design patterns in real world applications
     * 
     * Abstract factory is a super factory that creates other factories
     * 
     * 
     * CHOOSE ABSTRACT FACTORY PATERN WHEN
     * The application need to crete multiple families of objecs or products
     * We need to use only one of the subset of families of objects at a given point of time
     * We want to hide the implementations of the families of products by decoupling the implementation of 
     * each of these operations
     * 
     * BUSINESS REQUIREMENT (EXAMPLE)
     * Handout computers to Contract and Permanent employees based on the designation and employee type with below specifications
     * 
     * PERMANENT EMPLOYEE
     *  -   Managerial position is eligible for apple MAC Book Laptop
     *  -   Non Managerial Position is eligible for Apple IMac desktop
     * 
     * CONTRACT EMPLOYEE
     *  -   Managerial Positio is eligible for Dell Laptop
     *  -   Non Managerial Position is eligible for Dell desktop
     */
    public class Class1
    {
    }
}
