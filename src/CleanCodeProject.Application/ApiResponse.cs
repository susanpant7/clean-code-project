namespace CleanCodeProject.Application;

public class ApiResponse<T>
{
    public bool Success { get; set; }
    public string? Title { get; set; }
    public int Status { get; set; }
    public IEnumerable<string>? Errors { get; set; }
    public T? Data { get; set; }
    public object? Meta { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public ApiResponse() { }

    public ApiResponse(T data, bool success = true, string? title = null, int status = 200, IEnumerable<string>? errors = null, object? meta = null)
    {
        Data = data;
        Success = success;
        Title = title;
        Status = status;
        Errors = errors;
        Meta = meta;
    }

    public static ApiResponse<T> SuccessResponse(T data, string title = "Api Request Success", int status = 200, object? meta = null)
        => new ApiResponse<T>(data, true, title, status, null, meta);

    public static ApiResponse<T> ErrorResponse(string title, int status = 400, IEnumerable<string>? errors = null, object? meta = null)
        => new ApiResponse<T>(default!, false, title, status, errors, meta);
}