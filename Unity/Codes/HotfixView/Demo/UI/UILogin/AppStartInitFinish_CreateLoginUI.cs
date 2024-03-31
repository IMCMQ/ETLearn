using UnityEngine;

namespace ET
{
	public class AppStartInitFinish_CreateLoginUI: AEvent<EventType.AppStartInitFinish>
	{
		
		protected override void Run(EventType.AppStartInitFinish args)
		{
			UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid).Coroutine();
		
			// Test(args.ZoneScene).Coroutine();
			
			//同步事件
			//  Computer computer = args.ZoneScene.AddChild<Computer>();
			// // Game.EventSystem.Publish(new EventType.InstallComputer(){Computer =  computer});
			// //异步事件
			// Game.EventSystem.PublishAsync(new EventType.InstallComputerAsync(){Computer =  computer}).Coroutine();
			
			
			 
		}
		
		public async ETTask Test(Scene zoneScene)
		{
			//添加Computer实体，添加各种组件
			Computer computer = zoneScene.AddChild<Computer>();
			computer.AddComponent<PCCaseComponent>();
			computer.AddComponent<MonitorsComponent>();
			computer.AddComponent<KeyboardComponent>();
			computer.AddComponent<MouseComponent>();
			
			computer.Start();

			await TimerComponent.Instance.WaitAsync(3000);
		
			computer.Dispose();

			UnitConfig config = UnitConfigCategory.Instance.Get(1001);
			Debug.Log(config.Name);

			var allUnitConfig = UnitConfigCategory.Instance.GetAll();

			foreach (var unitConfig in allUnitConfig.Values)
			{
				Log.Debug(unitConfig.Name);

				Debug.Log(unitConfig.TestValue.ToString());
			}

			UnitConfig heighConfig = UnitConfigCategory.Instance.GetUnitConfigByHeight(178);
			Log.Debug(heighConfig.Name);
		}
	}
	

}
