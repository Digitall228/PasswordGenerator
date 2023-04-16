# PasswordGenerator
This is a small library for generating random character sequences.<br>
Usage:<br>
```c#
string keys = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM123456789";
int charactersCount = 8;
string result = PasswordGenerator.Generate(charactersCount, keys);
```
