# SimpleUnityBehaviourTreeRunner

A .NET 10 runner for [SimpleUnityBehaviourTree](https://github.com/konbraphat51/SimpleUnityBehaviourTree), allowing you to execute behavior trees outside of Unity.

## Features

- Uses SimpleUnityBehaviourTree as a git submodule
- Compatible with .NET 10 SDK
- Includes example implementation demonstrating basic behavior tree usage

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

## Getting Started

### Clone the repository with submodules

```bash
git clone --recurse-submodules https://github.com/konbraphat51/SimpleUnityBehaviourTreeRunner.git
cd SimpleUnityBehaviourTreeRunner
```

If you've already cloned without submodules:

```bash
git submodule update --init --recursive
```

### Build the project

```bash
dotnet build
```

### Run the example

```bash
dotnet run
```

## Project Structure

- `SimpleUnityBehaviourTree/` - Git submodule containing the behavior tree library
- `Program.cs` - Example implementation showing how to use the library
- `SimpleUnityBehaviourTreeRunner.csproj` - .NET project file
- `global.json` - Specifies .NET 10 SDK version

## Usage Example

The included `Program.cs` demonstrates:
- Creating custom sensor data and action structs
- Implementing a custom action node
- Creating and executing a behavior tree

## License

This project uses SimpleUnityBehaviourTree which is licensed under the MIT License. See the LICENSE file in the submodule for details.
