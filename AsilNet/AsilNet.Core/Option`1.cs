namespace AsilNet
{
    using System;
    using static Core;

    public class Option<T> : IEquatable<NoneObject>
    {
        private bool isSome;

        public T Value { get; } 
        
        internal Option(T value, bool isSome)
        {
            this.Value = value;
            this.isSome = isSome;
        }
        internal Option(T value)
            : this(value, value != null) { }

        internal Option()
            : this(default(T)) { }

        //TODO: Ensure - this can be a privat field
        public bool IsSome
        {
            get { return isSome; }
        }
        public static readonly Option<T> None = new Option<T>(default(T), false);
        
        public static implicit operator Option<T>(T value) => Some<T>(value);
        public static implicit operator Option<T>(NoneObject none) => None;

        public bool Equals(NoneObject other)
        {
            return !IsSome;
        }

        public override bool Equals(object obj)
        {
            if (! (obj is Option<T>)) return false;
            var optOther = (Option<T>) obj;
            if (IsSome && optOther.IsSome)
            {
                return this.Value.Equals(optOther.Value);
            }
            else if (!IsSome && !optOther.IsSome)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            if (IsSome) return Value.GetHashCode();
            else return base.GetHashCode();
        }
    }
}