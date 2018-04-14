# Object Oriented Programming Principles
The purpose of a software program is to solve some real world problem. The idea behaind a `Class` is to resemble real world object classes aka `My name is George an I am a person` = George is an instance of a Class Person.  In code : Person george = New Person();

# Inheritance
`Gains: Reuse code and reduce code duplication. Fix one bug in multiple places by changing code in one place.`  
`Drawbacks: Change in a base/parentclass effects all child/derived classes. Extending can lead to class explosion and hard to manage class hierarchy.`  
`When to use: When class hierarchy is simple.`  
`Personal rules: Child/Derived class must be a compleate substitute for its Parent/Base class`

# Polymorhism
`Gains: One common thing is done in different ways`  
`Drawbacks: Adds complexity to some people and in projects with big class hierarchy`  
`When to use: When having something common at the same time something different`  
`Personal Rules: carefull when calling methods in constructor`  

# Encapsulation
`Gains: Security and resilience`  
`Drawbacks: non known`  
`When to use: Simple = Always`  
`Personal Rules: Always use public property methods to access private fields`  

# Wiki quote on Encapsulation and Inheritance
`The authors of Design Patterns discuss the tension between inheritance and encapsulation at length and state that in their experience, designers overuse inheritance. The danger is stated as follows:
  Because inheritance exposes a subclass to details of its parent's implementation, it's often said that "inheritance breaks encapsulation" — Gang of Four, Design Patterns (Chapter 1)`

# Abstraction - The real sh*t
`Gains: Freedom of concreate implementation, Loose coupling`  
`Drawbacks: Introducing a level of indirection adds complexity`  
`When to use: When functionality, behaviour or logic can very. No need to apply to objects holding only data and no logic`  
`Personal Rules: Code verse some type of Abstraction (Abstract class, Interface) awlays when your code depends on some class outside of the language base library.`  

What is crappy writen code? => A code base that needs to be changed in order to extend logic/functionality.
Why people write Crappy code? => Quote: "How I can be sure that this code works if I don\`t know its implementation"
