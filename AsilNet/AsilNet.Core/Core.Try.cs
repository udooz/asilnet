namespace AsilNet
{
    using System;

    public static partial class Core
    {
        public static Try<S, F> Try<S, F>(S value) => new Try<S, F>(value);
        public static Try<S, F> Try<S, F>(F value) => new Try<S, F>(value);
        public static Try<S, Error> Try<S>(S value) => new Try<S, Error>(value);
        public static Try<S, Error> Try<S>(Error value) => new Try<S, Error>(value);
    }
}
