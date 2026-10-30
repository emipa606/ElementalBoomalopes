# GitHub Copilot Instructions for Elemental Boomalopes (Continued) Mod

## Mod Overview and Purpose

Elemental Boomalopes (Continued) is an update to the original Elemental Boomalopes mod. It adds new animal species to the RimWorld game that can be trained and used to fight against mechanoids and other threats. The mod introduces several different elemental-themed boomalopes, each with unique abilities and effects.

## Key Features and Systems

- **Elemental Boomalopes:** The mod adds four new elemental-themed boomalopes, each with unique abilities and effects. These include the Smoke Boomalope, Firefoam Boomalope, Stun Boomalope, and EMP Boomalope.
- **Toxic Version:** If the Biotech mod is active, the mod also adds a toxic version of the Boomalopes.
- **XML Integration:** The mod uses XML files to define the new pawn kinds and things, as well as to apply patches to existing game data.
- **Harmony Patching:** The mod uses Harmony patching to modify existing game code and add new functionality.

## Coding Patterns and Conventions

- **C# Code:** The mod uses C# code to define the behavior and effects of the new boomalopes. The code follows standard C# conventions and uses comments to explain the purpose of each method and class.
- **XML Files:** The mod uses XML files to define the new pawn kinds and things, as well as to apply patches to existing game data. The XML files use standard XML conventions and are well-documented to explain the purpose of each element and attribute.

## XML Integration

The mod uses XML files to define the new pawn kinds and things, as well as to apply patches to existing game data. The XML files are located in the `Defs` and `Patches` folders and are named according to the mod version and game version.

## Harmony Patching

The mod uses Harmony patching to modify existing game code and add new functionality. The Harmony patches are defined in the C# code files and are applied using the Harmony library.

## Suggestions for Copilot

- **Code Suggestions:** When working on C# code files, Copilot can suggest code snippets and methods that can be used to implement new functionality or modify existing code.
- **XML Suggestions:** When working on XML files, Copilot can suggest XML elements and attributes that can be used to define new pawn kinds and things or apply patches to existing game data.
- **Patch Suggestions:** When working on Harmony patches, Copilot can suggest code snippets and methods that can be used to modify existing game code and add new functionality.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

