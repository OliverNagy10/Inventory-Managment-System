public class ErrorResponse
{
    public ErrorInfo error { get; set; }
}

public class ErrorInfo
{
    public string code { get; set; }
    public string message { get; set; }
}
