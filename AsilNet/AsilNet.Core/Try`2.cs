namespace AsilNet
{
    using System;

    public class Try<S, F>
    {
        private S success;
        private F failed;
        private bool isSuccess;

        internal Try(S value)
        {
            this.success = value;
            this.failed = default(F);
            this.isSuccess = true;
        }

        internal Try(F value)
        {
            this.failed = value;
            this.success = default(S);
            this.isSuccess = false;
        }

        public bool IsSuccess => this.isSuccess;
        public bool IsFailed => !this.isSuccess;
        public S Success => this.success;
        public F Failed => this.failed;

        public static implicit operator Try<S, F>(S value) => new Try<S, F>(value);
        public static implicit operator Try<S, F>(F value) => new Try<S, F>(value);

        public override bool Equals(object obj)
        {
            if (!(obj is Try<S, F>)) return false;
            var tryOther = (Try<S, F>)obj;
            if (isSuccess && tryOther.isSuccess)
            {
                return this.success.Equals(tryOther.success);
            }
            else if (IsFailed && tryOther.IsFailed)
            {
                return this.failed.Equals(tryOther.failed); ;
            }
            return false;
        }

        public override int GetHashCode()
        {
            if (IsSuccess) return success.GetHashCode();
            else return failed.GetHashCode();
        }
    }
}
