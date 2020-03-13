## DI

Ther interface is the "registrant" and the implementation class is the injected implementation

### Types

__Transient__:
Everytime a registrant is called, it instantiates a new object.

__Singleton:__
The instantiated class will not be displosed through the lifespan of the application (one instance, stays the same)

__Scoped:__
~~A new instance is created on required class via the injection and . Useful as a state class.~~

### Method 1: In Startup.cs/ConfigureServices

### Method 2: In Main.cs/WebHostuilder()

