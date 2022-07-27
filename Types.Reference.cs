// A part of the C# Language Syntactic Sugar suite.

namespace CLSS
{
  /// <summary>
  /// A reference-type wrapper for any value type. Can also be used to wrap
  /// around other reference types, should there exist use cases for that.
  /// </summary>
  /// <typeparam name="T">The type of the value being wrapped.</typeparam>
  public class Reference<T>
  {
    /// <summary>
    /// The field that contains the actual value being encapsulated.
    /// </summary>
    protected T _value = default;

    /// <summary>
    /// The encapsulated value.
    /// </summary>
    public virtual T Value { get { return _value; } set { _value = value; } }

    /// <summary>
    /// Initializes a new instance of the <see cref="Reference{T}"/> with its
    /// value initialized to <paramref name="initialValue"/>.
    /// </summary>
    /// <param name="initialValue">The initial value of the reference.</param>
    public Reference(T initialValue) { _value = initialValue; }
  }
}
