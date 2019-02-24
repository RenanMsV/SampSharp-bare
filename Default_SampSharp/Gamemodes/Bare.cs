using System;
using SampSharp.GameMode; // Contains BaseMode class
using SampSharp.GameMode.Events;
using SampSharp.GameMode.SAMP.Commands;
using SampSharp.GameMode.World;
using SampSharp.GameMode.Definitions;

namespace Default_SampSharp.Gamemodes
{
    public class Bare : BaseMode
    {
        #region Overrides of BaseMode

        protected override void OnInitialized(EventArgs e)
        {

            base.OnInitialized(e);

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("  Bare Script\n");
            Console.WriteLine("----------------------------------\n");

            SetGameModeText("Bare Script");
            ShowPlayerMarkers(PlayerMarkersMode.Global);
            ShowNameTags(true);
            //AllowAdminTeleport(1); // deprecated, use OnPlayerClickMap instead
            AddPlayerClass(265, new Vector3(1958.3783f, 1343.1572f, 15.3746f), 270.1425f); ;

        }

        protected override void OnPlayerConnected(BasePlayer player, EventArgs e)
        {
            base.OnPlayerConnected(player, e);
            player.GameText("~w~SA-MP: ~r~Bare Script", 5000, 5);  
        }

        protected override void OnPlayerRequestClass(BasePlayer player, RequestClassEventArgs e)
        {
            base.OnPlayerRequestClass(player, e);
            SetupPlayerForClassSelection(player);
        }

        protected override void OnPlayerSpawned(BasePlayer player, SpawnEventArgs e)
        {
            base.OnPlayerSpawned(player, e);
            player.Interior = 0;
            player.ToggleClock(false);
        }

        #endregion

        #region Commands
        [Command("yadayada")]
        public static bool yadayada(BasePlayer sender)
        {
            return true;
        }
        #endregion

        #region Utils

        private void SetupPlayerForClassSelection(BasePlayer player)
        {

            player.Interior = 14;
            player.Position = new Vector3(258.4893f, -41.4008f, 1002.0234f);
            player.Angle = 270f;
            player.CameraPosition = new Vector3(256.0815f, -43.0475f, 1004.0234f);
            player.SetCameraLookAt(new Vector3(258.4893f, -41.4008f, 1002.0234f));
        }
        #endregion
    }
}
