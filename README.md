# GUI config tool for the Oblivion Randomizer

## Build instructions

Execute this in a CLI(Powershell):

	dotnet publish obrandomizer-gui.csproj -c Release --no-self-contained

The exe will be extracted in (project_dir)\Release\bin\win-x(86/64) with its pdb and .dll.config files, which are not needed.
