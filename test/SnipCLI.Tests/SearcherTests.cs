using System;
using System.Collections.Generic;
using SnipCLI.Models;
using Xunit;

namespace SnipCLI.Tests
{
    public class SearcherTests
    {

        [Fact]
        public void OneArgument_SearchCommandLine()
        {
            //Arrange
            //Arguments
            string[] args = {"build"};

            //CommandLibrary
            var config = new List<SnipConfig>
            {
                new SnipConfig{HowTo= "Run a .NET Core code", Platform="dotnet core", CommandLine="dotnet run" },
                new SnipConfig{HowTo= "Build a .NET Core code", Platform="dotnet core", CommandLine="dotnet build" },
                new SnipConfig{HowTo= "Roll back a migration", Platform="dotnet core ef", CommandLine="dotnet ef migrations remove" }
            };

            //Act
            var results = Searcher.ReturnCommands(config, args);

            //Assert
            Assert.Equal("dotnet build", results[0].CommandLine);

        }

        [Fact]
        public void TwoArguments_SearchCommandLine()
        {
            //Arrange
            //Arguments
            string[] args = {"build", "remove"};

            //CommandLibrary
            var config = new List<SnipConfig>
            {
                new SnipConfig{HowTo= "Run a .NET Core code", Platform="dotnet core", CommandLine="dotnet run" },
                new SnipConfig{HowTo= "Build a .NET Core code", Platform="dotnet core", CommandLine="dotnet build" },
                new SnipConfig{HowTo= "Roll back a migration", Platform="dotnet core ef", CommandLine="dotnet ef migrations remove" }
            };

            //Act
            var results = Searcher.ReturnCommands(config, args);

            Assert.Equal(2, results.Count);
        }
    }
}
