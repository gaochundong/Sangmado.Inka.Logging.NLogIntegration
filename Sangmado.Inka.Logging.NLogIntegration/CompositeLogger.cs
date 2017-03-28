namespace Sangmado.Inka.Logging.NLogIntegration
{
    public class CompositeLogger : Sangmado.Inka.Logging.ILogger
    {
        public CompositeLogger()
        {
        }

        public Sangmado.Inka.Logging.ILog Get(string name)
        {
            return new CompositeLog(Logrila.Logging.Logger.Get(name));
        }

        public static void Use()
        {
            Logrila.Logging.Logger.UseLogger(new Logrila.Logging.NLogIntegration.NLogLogger());
            Sangmado.Inka.Logging.Logger.UseLogger(new CompositeLogger());
        }
    }
}
