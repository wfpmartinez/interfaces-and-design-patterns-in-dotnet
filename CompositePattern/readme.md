# Composite Pattern
The Composite design pattern represents hierarchies of objects. 

When using this pattern, clients should be able to treat groups of objects in a hierarchy as the same even though they can be different. 
You can do this selectively to parts of the hierarchy, or to the entire hierarchy.

## Type: 
Structural

## Explanation 
The Component declares an interface for objects in the composition. 
The Leaves represent leaf (an object with no children) behavior in the composition. It also defines primitive behavior.
The Composite defines behavior for components which have children (contrasting the Leaves). =
The Client manipulates objects in the composition through the Component interface.