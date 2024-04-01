using ET.EventType;

namespace ET
{
    public class InstallComputer_AddComponent : AEvent<EventType.InstallComputer>
    {
        protected override void Run(InstallComputer arg)
        {
            Computer computer = arg.Computer;
            computer.AddComponent<PCCaseComponent>();
            computer.AddComponent<MonitorsComponent>();
            computer.AddComponent<KeyboardComponent>();
            computer.AddComponent<MouseComponent>();
            computer.Start();
        }
    }
}