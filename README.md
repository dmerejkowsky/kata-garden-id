# Solution - contains spoilers

Various ways:
* Return a string with more details
* Return an error code
* Log the problem
* Throw an exception


Value object: create a `GardenId` type and move the check in the constructor,
for instance:

```python
class GardenId:
    def __init__(self, value):
        check_is_valid(value)
        self._value = value

    def value(self):
        return self._value
```
