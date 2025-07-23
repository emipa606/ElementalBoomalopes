# .github/copilot-instructions.md

## Mod Overview and Purpose
The "Elemental Boomers" mod for RimWorld introduces a series of unique creatures with explosive elemental abilities. Each creature has a specific death action that triggers a large or small explosion, releasing various effects such as EMP, FireFoam, Smoke, Stun, or ToxGas. This mod aims to enhance gameplay by adding strategic depth and variety, encouraging players to adapt their approaches when dealing with different types of explosive creatures.

## Key Features and Systems
- **Elemental Boomers:** Introduces new boomer creatures that explode upon death, each with unique elemental effects.
- **Death Action Mechanics:** Upon the death of a boomer, a specific explosion type is triggered, causing different effects on the surroundings.
- **Explosion Varieties:** Includes both small and large explosion variants with the following effects:
  - EMP (Electromagnetic Pulse)
  - FireFoam suppression
  - Smoke cloud creation
  - Area Stun
  - Toxic Gas release

## Coding Patterns and Conventions
- **Class Naming:** Each class is named according to its functionality, e.g., `DeathActionWorker_BigExplosion_EMP` for a large EMP explosion upon death.
- **Inheritance:** Explosion types are implemented as subclasses of `DeathActionWorker`, a core RimWorld class for handling death actions.
- **Consistent Method Signatures:** While methods are not listed, all classes follow RimWorld's architecture and method signature conventions for `DeathActionWorker`.

## XML Integration
- Utilize XML to define the properties of each boomer creature, including its attributes, such as health, attack types, and associated explosion effect. 
- Structure XML files to map each creature definition to its corresponding C# class for seamless integration.
- Ensure that creature definitions include references to the mod in the `Defs` folder for easy addition or modification.

## Harmony Patching
- **Harmony Patches:** If required, apply Harmony patches to modify game behaviors that are not directly accessible through XML or standard RimWorld modding conventions.
- **Purpose of Patches:** Utilize patches to extend or alter the functionality of death actions or explosion effects beyond what's possible with vanilla code.
- **Guidelines for Patches:** Ensure all patches are conflict-free and modular by targeting specific methods and avoiding global changes.

## Suggestions for Copilot
- **Class Boilerplate:** Use Copilot to quickly generate boilerplate code for new `DeathActionWorker` subclasses, ensuring each class follows the required base class and overrides necessary methods from `DeathActionWorker`.
- **XML Definitions:** Leverage Copilot for creating well-structured and error-free XML definitions by suggesting snippets that match the common formatting used in RimWorld mods.
- **Harmony Templates:** Suggest templates or code snippets for common Harmony patch patterns to streamline the creation of patches when necessary.

By applying these guidelines and leveraging GitHub Copilot’s capabilities, developers can efficiently maintain and expand the "Elemental Boomers" mod, enhancing its functionality and performance within the RimWorld ecosystem.
