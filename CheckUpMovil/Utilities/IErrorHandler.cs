using System;

namespace CheckUpMovil.Utilities
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}
