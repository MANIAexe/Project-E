using ProjectE.Evrima.SDK.Transport;

namespace ProjectE.Evrima.SDK;

public sealed class EvrimaServer
{
    private readonly ICommandTransport _transport;

    public EvrimaServer(ICommandTransport transport)
    {
        _transport = transport;
    }

    public Task<string> ExecuteAsync(string command, CancellationToken cancellationToken = default)
    {
        return _transport.SendAsync(command, cancellationToken);
    }

    public Task<string> AnnounceAsync(string message, CancellationToken cancellationToken = default)
    {
        return ExecuteAsync($"announce {message}", cancellationToken);
    }
}
