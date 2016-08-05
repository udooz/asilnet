namespace AsilNet
{
    using System;

    public static partial class Core
    {
        public static R Match<T, R>(Option<T> @this,
            Func<T, R> Some, Func<R> None) =>
                @this.IsSome ? Some(@this.Value) : None();
    }
}
