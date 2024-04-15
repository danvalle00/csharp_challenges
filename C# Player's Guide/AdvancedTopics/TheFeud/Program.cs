using IField;
using McDroid;
using McPig = McDroid.Pig;
Console.Title = "The Feud";

Sheep sheep = new Sheep();
Cow cow = new Cow();

IField.Pig pig = new IField.Pig(); // fully qualified
McPig pig2 = new McPig(); // alias 

namespace IField
{
    public class Sheep()
    {

    }
    public class Pig()
    {
        
    }
}


namespace McDroid
{
    public class Cow()
    {
        
    }

    public class Pig()
    {
        
    }
}
