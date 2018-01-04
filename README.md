# csharp_utils

Code snippets and tool classes in C Sharp

## Classes

Guiosoft.Antivirus (static)

```c#
public static AVInfo[] AVList	// List of the antivirus installed
```
```c#
public static string AVInfo()	// Returns string with all the antivirus installed on the system
```
```c#
public static void Update()		// Update the list of antivirus
```

Guiosoft.Firewall (static)
```c#
public static FWInfo[] FWList	// List of the firewalls installed
```
```c#
public static string FWInfo()	// Returns string with all the antivirus installed on the system
```

## Extensions

```c#
using Guiosoft.Extensions;
```

### Numbers
```c#
(double, decimal).ToSQL()	// Returns string representation of value to use in SQL expression
```
```c#
(double, decimal).IsZero(int decimals = 2)	// Returns if a value is pratical zero 
```
```c#
(double, decimal).IsEqual(another, int decimals = 2)	// Returns if a value is pratical zero 
```


### DateTime
```c#
DateTime.ToSQL()	// Returns string representation of value to use in SQL expression
```