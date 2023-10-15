using Adapter_Pattern.Adaptees;
using Adapter_Pattern.Adapters;
using Adapter_Pattern.BaseClasses;

ISquare square = new Square();
square.DrawSquare(); // Output: Drawing Square

ICircle circle = new Circle();
ISquare circleAdapter = new CircleAdapter(circle);
circleAdapter.DrawSquare(); // Output: Drawing Circle (via CircleAdapter)
