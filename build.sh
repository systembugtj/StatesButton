#!/usr/bin/env bash

nuget restore src/StatesButton.Forms.sln -verbosity detailed
msbuild src/tatesButton.Forms.sln /p:Configuration=Release

nuget pack nuspec/StatesButton.Forms.nuspec
nuget add StatesButton.Forms.3.0.2.nupkg -source ~/localpackages
