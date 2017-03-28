namespace RockStone.Inka.Logging.NLogIntegration
{
    public class CompositeLogger : RockStone.Inka.Logging.ILogger
    {
        public CompositeLogger()
        {
        }

        public RockStone.Inka.Logging.ILog Get(string name)
        {
            return new CompositeLog(Logrila.Logging.Logger.Get(name));
        }

        public static void Use()
        {
            Logrila.Logging.Logger.UseLogger(new Logrila.Logging.NLogIntegration.NLogLogger());
            RockStone.Inka.Logging.Logger.UseLogger(new CompositeLogger());
        }
    }
}
