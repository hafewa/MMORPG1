using QFramework;
using UnityEngine;

namespace MMORPG.Game
{
    public enum LaunchStatus
    {
        InitLog,
        InitPlugins,
        InitTool,
        InitNetwork,
        InLobby,
        Playing,
        ApplicationQuit
    }

    public class LaunchController : MonoSingleton<LaunchController>, IController
    {
        public FSM<LaunchStatus> FSM = new();

        private void Awake()
        {
            DontDestroyOnLoad(this);
        }

        private void Start()
        {
            Serilog.Log.Information("开始生命周期");
            FSM.AddState(LaunchStatus.InitLog, new InitLogState(FSM, this));
            FSM.AddState(LaunchStatus.InitPlugins, new InitPluginsState(FSM, this));
            FSM.AddState(LaunchStatus.InitTool, new InitToolState(FSM, this));
            FSM.AddState(LaunchStatus.InitNetwork, new InitNetworkState(FSM, this));
            FSM.AddState(LaunchStatus.InLobby, new InLobbyState(FSM, this));
            FSM.AddState(LaunchStatus.Playing, new PlayingState(FSM, this));
            FSM.AddState(LaunchStatus.ApplicationQuit, new ApplicationQuitState(FSM, this));

            FSM.StartState(LaunchStatus.InitLog);
        }

        public IArchitecture GetArchitecture()
        {
            return GameApp.Interface;
        }

        protected override void OnApplicationQuit()
        {
            base.OnApplicationQuit();

            Serilog.Log.CloseAndFlush();
            FSM.ChangeState(LaunchStatus.ApplicationQuit);
            FSM.Clear();

            GameApp.Interface.Deinit();
        }
    }
}
