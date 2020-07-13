using System.Collections.Generic;

namespace Ping.Models
{
  public class PingPong
  {
    public static List<string>  Play(int number)
    {
      List<string> returnList = new List<string>();
      for (int i = 1; i <= number; i++)
      {
        if ((i % 3 == 0) && (i % 5 == 0))
        {
          returnList.Add("ping-pong");
        }
        else if (i % 3 == 0)
        {
          returnList.Add("ping");
        }
        else if (i % 5 == 0)
        {
          returnList.Add("pong");
        }
        else
        {
          returnList.Add(i.ToString());
        }
      }
      return returnList;
    }
  }
}