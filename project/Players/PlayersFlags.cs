using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Query;

namespace project.Players
{
    public class PlayersFlags
    {
        public static sQuery TCPr;
        public static RCONQuery TCPs;

        public static void SetPlayerHealth(int playerid, float health)
        {
            TCPs.Send(string.Format("vida {0} {1}", playerid, health));
        }
        public static void SetPlayerArmour(int playerid, float armour)
        {
            TCPs.Send(string.Format("colete {0} {1}", playerid, armour));
        }
        public static void SendClientMessage(int playerid, string msg)
        { 
            TCPs.Send(string.Format("msg {0} {1}", playerid, msg));
        }
        public static void CreateVehicle(int playerid, int vehicleid)
        {
            TCPs.Send(string.Format("veh {0} {1}", playerid, vehicleid));
        }
        public static void DestroyVehicle(int playerid)
        {
            TCPs.Send(string.Format("veh {0} -1", playerid));
        }
        public static void Kick(int playerid)
        {
            TCPs.Send(string.Format("kick {0}", playerid));
        }
        public static void Ban(int playerid)
        {
            TCPs.Send(string.Format("ban {0}", playerid));
        }
    }
}
