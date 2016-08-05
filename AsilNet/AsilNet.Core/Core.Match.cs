namespace AsilNet
{
    using System;

    public static partial class Core
    {
        public static R Match<T, R>(Option<T> option,
            Func<T, R> Some, Func<R> None) =>
                option.IsSome ? Some(option.Value) : None();
    }
}
