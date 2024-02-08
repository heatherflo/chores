using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.SignalR;

namespace chores.Models;


public class Chore
{

  public string Id { get; private set; } = Guid.NewGuid().ToString();

  public string Name { get; set; }

  public bool IsHard { get; set; }

  public bool IsOutdoor { get; set; }

  public double MinutesLong { get; set; }

  public Chore(string name, bool isHard, bool isOutdoor, double minutesLong)
  {
    Name = name;
    IsHard = isHard;
    IsOutdoor = isOutdoor;
    MinutesLong = minutesLong;
  }
}

