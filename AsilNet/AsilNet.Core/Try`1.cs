namespace AsilNet
{
    using System;

    public class Try<S> : Try<S, Error>
    {
        public Try(S value)
            : base(value){}

        public Try(Error error)
            : base(error) { }

        public static implicit operator Try<S>(S value) => new Try<S>(value);
        public static implicit operator Try<S>(Error value) => new Try<S>(value);
    }
}
