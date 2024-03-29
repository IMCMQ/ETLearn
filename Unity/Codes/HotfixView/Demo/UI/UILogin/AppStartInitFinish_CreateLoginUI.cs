

namespace ET
{
	public class AppStartInitFinish_CreateLoginUI: AEvent<EventType.AppStartInitFinish>
	{
		protected override void Run(EventType.AppStartInitFinish args)
		{
			UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid).Coroutine();

			Computer computer = args.ZoneScene.AddChild<Computer>();
			computer.AddComponent<PCCaseComponent>();
			computer.AddComponent<MonitorsComponent>();
			computer.AddComponent<KeyboardComponent>();
			computer.AddComponent<MouseComponent>();
			
			computer.Start();
		}
	}
}
