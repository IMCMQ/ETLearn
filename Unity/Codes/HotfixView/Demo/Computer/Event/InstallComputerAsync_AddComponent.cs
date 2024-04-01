using ET.EventType;

namespace ET
{
    public class InstallComputerAsync_AddComponent : AEventAsync<EventType.InstallComputerAsync>
    {
        protected async override ETTask Run(InstallComputerAsync a)
        {
            Computer computer = a.Computer;

            computer.AddComponent<PCCaseComponent>();
            computer.AddComponent<MonitorsComponent>();
            computer.AddComponent<MouseComponent>();
            computer.AddComponent<KeyboardComponent>();

            await TimerComponent.Instance.WaitAsync(3000);
            
            computer.Start();
        }
    }
}