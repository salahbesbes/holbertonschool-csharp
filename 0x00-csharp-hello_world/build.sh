#!/usr/bin/env bash

if [ $# -eq 0 ]; then
  echo "No arguments supplied"
  exit
fi

projectName=$1
dotnet build "$projectName"
