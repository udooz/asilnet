namespace AsilNetCore.Tests
{
    using System;

    public class MyError
    {
        public int Code { get; set; }

        public MyError(int code)
        {
            Code = code;
        }

        public MyError()
        {

        }

        public override bool Equals(object obj)
        {
            if ((!(obj is MyError)) || obj == null) return false;
            var other = (MyError)obj;
            if (Code == other.Code) return true;
            return false;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }
    }
}
