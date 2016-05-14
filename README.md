ValueWithUnit experiment
========================

This project aim to add types for most standard unit defined by the International System of Units as .Net structures.

Such structures should :

* Take only the size of a double, such that storing an array of them stay efficient memory-wise.
* Support operations between values having an unit and values without units.
* Support operations between supported values that result in other supported values to work (km * s/m -> s)
* Fallback gracefully to a generic structure if no specific structure exists for a given unit.
* Keep all operations working in this generic structure.
* Allow special no units to be keept and act naturally (radians, steradians, power ratio, ...)

Sample
------

The basic target of this library could be explained with this simple sample :

```csharp
var c = 299792458.0 * Length.Metre / Time.Second; // Speed of light in vacum
var au = 149597870.7 * Length.Kilometre; // Astronomical unit (distance between the Earth and the Sun)

var timeForLightToReachEarth = au / c;
 
Console.WriteLine("Light from the sun travel for {0} before reaching earth", (Seconds)timeForLightToReachEarth);
```
