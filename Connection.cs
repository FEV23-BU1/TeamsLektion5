using System.Net.Sockets;

namespace TeamsLektion5;

public class Connection
{
    public Socket Socket { get; set; }

    public User User { get; set; }
}
