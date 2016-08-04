namespace AsilNet
{
    using System;
    using static Core;

    public class Option<T> : IEquatable<NoneObject>
    {       
        public T Value { get; } 
        
        public Option(T value)
        {
            this.Value = value;
        }

        public Boolean IsSome => Value != null;
        public static implicit operator Option<T>(T value) => Some<T>(value);
        public static implicit operator Option<T>(NoneObject none) => None;

        public bool Equals(NoneObject other)
        {
            return !IsSome;
        }
    }
}