# Factory Design Pattren => Creational

What is Factory Design Pattern: Gang of Four Definition 
Define an interface for creating an object, but let subclasses decide which class to instantiate. The Factory method lets a class defer instantiation it uses to subclasses

Factory pattern is one of the most used design patterns in real-world applications. Factory pattern creates objects without exposing the creation logic to the client and refers to newly created objects using a common interface

Implementation Guidelines

We need to choose a Factory Pattern when
1. The Object needs to be extended to subclasses
2. The Classes doesn’t know what exact sub-classes it has to create
3. The Product implementation tends to change over time and the Client remains unchanged

 In this repo you will find implementation for:
1. Simple Factory
2. Factory Method Pattern
