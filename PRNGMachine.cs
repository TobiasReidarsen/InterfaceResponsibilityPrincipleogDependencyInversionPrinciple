namespace InterfaceResponsibilityPrincipleogDependencyInversionPrinciple
{
    internal class PRNGMachine
    {
        // need to make a random number generator.
        // need a seed. Could use DateTime.Now?

        // private const Seed = DateTime.Now;
        private int Seed { get; set; }

        private void CreateSeed()
        {
            Seed = (int)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds;
            Console.WriteLine(Seed);


        }
    }
}
