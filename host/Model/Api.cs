namespace Lyt.Host.Model
{
  public record ApiError(
    string? message = default,
    string? stack = default
  );

  public record ApiReponse(
    IEnumerable<ApiError>? errors = default
  );

  public record ApiReponse<T>(
    T? value = default,
    IEnumerable<ApiError>? errors = default
  ) : ApiReponse(errors);
}