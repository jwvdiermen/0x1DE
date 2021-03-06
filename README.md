# (Abandoned) C# / .NET IDE for the DCPU-16

A C# / .NET based IDE mainly focussed on the DCPU-16, a CPU used by the new game [0x10c](http://0x10c.com/) written by Notch.

See: [http://0x10c.com/doc/dcpu-16.txt](http://0x10c.com/doc/dcpu-16.txt)

## About

This project will contain an IDE which you can use for the upcoming game [0x10c](http://0x10c.com/).
The IDE will mainly focus on development for the DCPU-16, a virtual CPU used in the game.

So what can you expect?

* A code editor for the assembly code.
* A compiler and linker for working with multiple files.
* A testing environment with virtual screen and keyboard.
* Additional I/O when documented by Notch.
* And much more...

## ToDo

Below is a very rough list of things to do, in appearing order:

* Decouple the Virtual Machine found [here](https://github.com/jwvdiermen/DCPU-16), into a class library.
* Create the basic user interface.
* Create a disassembler.
* Create a compiler.
* Create a simple debugger, allowing to go step by step through the code. You'll have access to all the processor values and see the current executing line.
* Add functionality to easy add memory mapped I/O.
* Implement a virtual screen.
* Implement a virtual keyboard.
* Make a more fancy code editor.
* More to follow...

# License

I don't have a lot of experiences with licenses and open-source projects. I guess I'll use the GPL license.
More on this later...
