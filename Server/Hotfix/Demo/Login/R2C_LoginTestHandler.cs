namespace ET.Login
{
    [MessageHandler]
    public class R2C_LoginTestHandler : AMHandler<C2R_SayHello>
    {
        protected override async void Run(Session session, C2R_SayHello message)
        {
            Log.Debug(message.Hello);

            session.Send(new R2C_SayGoodBye(){GoodBye = "goodBye"});
            await ETTask.CompletedTask;
        }
    }
}