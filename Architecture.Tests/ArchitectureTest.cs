using System.Reflection.Metadata;
using System.Reflection;
using NetArchTest.Rules;
using Xunit;

namespace Architecture.Tests;

public class ArchitectureTest
{
    private const string DomainNamespace = "Domain";
    private const string ApplicationNamespace = "Application";
    private const string InfrastructureNamespace = "Infrastructure";
    private const string PresentationNamespace = "Presentation";
    private const string WebNamespace = "Web";
    [Fact]
    public void Domain_Should_not_HaveDependencyOnOtherProjects()
    {
        //arrange
        var assembly =typeof(Domain.AssemblyReference).Assembly;
        var otherProjects = new[]
        {
            ApplicationNamespace,
            InfrastructureNamespace,
            PresentationNamespace,
            WebNamespace
        };
        //act
        var testResult = Types.
            InAssembly(assembly).
            ShouldNot().
            HaveDependencyOnAll(otherProjects).
            GetResult();
        //assert
        Assert.True(testResult.IsSuccessful);
    }
    [Fact]
    public void Application_Should_not_HaveDependencyOnOtherProjects()
    {
        //arrange
        var assembly = typeof(Application.AssemblyReference).Assembly;
        var otherProjects = new[]
        {
            InfrastructureNamespace,
            PresentationNamespace,
            WebNamespace
        };
        //act
        var testResult = Types.
            InAssembly(assembly).
            ShouldNot().
            HaveDependencyOnAll(otherProjects).
            GetResult();
        //assert
        Assert.True(testResult.IsSuccessful);
    }
    [Fact]
    public void Infrastructure_Should_not_HaveDependencyOnOtherProjects()
    {
        //arrange
        var assembly = typeof(Infrastructure.AssemblyReference).Assembly;
        var otherProjects = new[]
        {
            PresentationNamespace,
            WebNamespace
        };
        //act
        var testResult = Types.
            InAssembly(assembly).
            ShouldNot().
            HaveDependencyOnAll(otherProjects).
            GetResult();
        //assert
        Assert.True(testResult.IsSuccessful);
    }

}

