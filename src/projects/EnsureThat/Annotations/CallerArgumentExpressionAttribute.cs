#if NETSTANDARD2_1
namespace System.Runtime.CompilerServices;

/// <summary>Indicates that a parameter captures the expression passed for another parameter as a string.</summary>
[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
public sealed class CallerArgumentExpressionAttribute : Attribute
{
    /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.CallerArgumentExpressionAttribute" /> class.</summary>
    /// <param name="parameterName">The name of the parameter whose expression should be captured as a string.</param>
    public CallerArgumentExpressionAttribute(string parameterName)
    {
        this.ParameterName = parameterName;
    }

    /// <summary>Gets the name of the parameter whose expression should be captured as a string.</summary>
    /// <returns>The name of the parameter whose expression should be captured.</returns>
    public string ParameterName { get; }
}
#endif
