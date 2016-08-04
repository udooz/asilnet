namespace AsilNet
{
    using System;

    public static partial class Core
    {
        public static Option<T> Some<T>(T value) => new Option<T>(value);
        public static readonly NoneObject None = NoneObject._;
    }
}
