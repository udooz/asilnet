namespace AsilNet
{
    using System;

    public class Error
    {
        private int errCode;
        private string plainMsg;
        private bool isCodeBasedError;

        public Error(int errCode)
        {
            this.errCode = errCode;
            isCodeBasedError = true;
        }

        public Error(string message)
        {
            this.plainMsg = message;
            isCodeBasedError = false;
        }

        public int Code => errCode;
        public string Message => plainMsg;

        public static Error As(int errorCode) => new Error(errorCode);
        public static Error As(string message) => new Error(message);
    }
}
