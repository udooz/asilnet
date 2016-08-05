namespace AsilNet
{
    using System;

    public static partial class Core
    {
        public static R Match<T, R>(this Option<T> @this,
            Func<T, R> Some, Func<R> None) =>
                (! (@this is NoneObject)) && @this.IsSome ? Some(@this.Value) : None();
    }
}
