using System;
using System.Collections.Generic;
using System.Text;

namespace Nexora.Domain.Common.Results;

public class Result
{
    public bool IsSuccess { get; }

    public bool IsFailure => !IsSuccess;

    public string? Error { get; }

    protected Result(bool isSuccess, string? error)
    {
        if (isSuccess && error is not null)
            throw new ArgumentException(
                "Successful result cannot contain an error.");

        if (!isSuccess && string.IsNullOrWhiteSpace(error))
            throw new ArgumentException(
                "Failed result must contain an error.");

        IsSuccess = isSuccess;
        Error = error;
    }

    public static Result Success()
        => new(true, null);

    public static Result Failure(string error)
        => new(false, error);
}

public sealed class Result<T> : Result
{
    public T? Value { get; }

    private Result(bool isSuccess, T? value, string? error)
        : base(isSuccess, error)
    {
        Value = value;
    }

    public static Result<T> Success(T value)
        => new(true, value, null);

    public new static Result<T> Failure(string error)
        => new(false, default, error);
}
