namespace FluentMigrator.Runner.Generators
{
    public static class CompatabilityModeExtension
    {
        public static string HandleCompatibilty(this CompatabilityMode mode, string message)
        {
            if (CompatabilityMode.STRICT == mode)
            {
                throw new DatabaseOperationNotSupportedException(message);
            }
            return string.Empty;
        }
    }
}