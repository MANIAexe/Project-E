namespace ProjectE.Evrima.SDK.Transport;

public interface ICommandTransport
{
    Task<string> SendAsync(string command, CancellationToken cancellationToken = default);
}
