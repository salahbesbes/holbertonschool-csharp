#!/usr/bin/env bash

# create new Project it takes the project name and rename the file with the same name

if [ $# -eq 0 ]; then
  echo "No arguments supplied"
  exit
fi


IFS='' read -r -d '' String <<"EOF"
\t\t<DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>
EOF

projectName=$1


dotnet new console -o "$projectName" --force
mv "$projectName"/Program.cs "$projectName"/"$projectName".cs
sed -i "3 a \ $String " "$projectName"/"$projectName".csproj



