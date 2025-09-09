using TwitterAnalysis.Infrastructure.Utils.Interfaces;

namespace TwitterAnalysis.Infrastructure.Utils
{
    public static class Result
    {
        public static IOperation CreateSuccess() => new SuccessFulOperation();

        public static IOperation CreateSuccess<T>() => new SuccessFulOperation();

        public static IOperation CreateFailure<T>(ErrorCodes code) => new FailedOperation(code);

        public static IOperation CreateFailure<T>(ErrorCodes code, MessageDetail messageDetail) => new FailedOperation(code, messageDetail);

        public static IOperation CreateFailure<T>(ErrorCodes code, List<MessageDetail> messageDetail) => new FailedOperation(code, messageDetail);

        public static IOperation<T> CreateFailure<T>(ErrorCodes code, T value) => new FailedOperation<T>(code, value);

        public static IOperation CreateFailure<T>(Messages messages) => new FailedOperation(messages);
    }
}
