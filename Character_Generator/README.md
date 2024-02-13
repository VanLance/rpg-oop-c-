# QuestForge Character Generator

## Overview

QuestForge Character Generator is a .NET application built using the WPF framework. It serves as a character generator following complex Dungeons & Dragons (D&D) guidelines. The application receives user input via a user-friendly interface, processes it through C# classes, and generates playable characters, adhering to the intricate rules and mechanics of the D&D system.

## Features

- **Character Generation**: Create customized characters by selecting their name, archetype (class), and race.
- **Stat Calculation**: Automatically calculates stats such as hit points (HP), armor class (AC), and ability scores based on selected options.
- **User-Friendly Interface**: Intuitive UI design allows for easy navigation and input.
- **Real-time Display**: Updates character information in real-time for quick reference.

## Implementation Details

### Object-Oriented Programming (OOP)

- **Inheritance**: Utilized in `Archetype.cs` and `Race.cs` to model the inheritance hierarchy between different character archetypes and races.
- **Encapsulation**: Demonstrated in `Stats/HealthPointsManager.cs`, where health point management logic is encapsulated within a single class, ensuring data integrity and modularity.
- **Modularity**: The project is structured into multiple classes and files, promoting modularity and ease of maintenance. Each class or file focuses on a specific aspect of character generation or statistics calculation, enhancing code organization and reusability.

### Algorithms

- **Two Pointer**: Implemented in `BuildStats.cs` for efficiently calculating character statistics based on rolled dice values.

### Modularity and Scalability

- **Modular Design**: The project is designed with modularity in mind, allowing for easy extension and modification of different components without affecting the overall system. Each class or module is responsible for a specific functionality, making it easier to understand and maintain the codebase.
- **Scalability**: The architecture of the application enables scalability, meaning that it can accommodate future enhancements or changes without requiring significant restructuring. As the project grows, new features can be added with minimal impact on existing code, facilitating the long-term evolution of the application

## How to Use

To use the QuestForge Character Generator:

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or your preferred IDE.
3. Build and run the application.
4. Enter the character name, select the archetype and race from the dropdown menus, and click the "Submit" button.
5. Review the generated character details displayed on the screen.

## To Do

- **Incorporate Windows Communication Foundation (WCF)**: Explore the integration of WCF to enable communication between different components of the application or with external systems. 

- **Expand Character Generation Options**: Extend the character generation capabilities by adding support for additional archetypes, races, or character customization options. This could involve incorporating data from external sources, such as supplemental rulebooks or community-created content, to offer a wider variety of character creation possibilities.

- **Implement Persistence**: Integrate data persistence functionality to allow users to save and load character profiles. This could involve storing character data in a local database or file system, enabling users to revisit and modify previously created characters at their convenience.

- **Enhance Error Handling and Validation**: Improve error handling and input validation mechanisms to ensure a robust and error-tolerant application. Implement error messages and validation checks to guide users in providing correct input and prevent unintended behavior or data corruption.

## Contributing

Contributions to the QuestForge Character Generator project are welcome! If you have any ideas for improvements or new features, feel free to open an issue or submit a pull request.

## Credits

This project was developed by Dylan Smith

