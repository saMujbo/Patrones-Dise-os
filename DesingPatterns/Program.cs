using DesingPatterns.StructuralPatterns.Proxy;

// Uso del Proxy

Console.WriteLine("Client: Trying to access the safe with Mr. Link directly:");
MrLink mrLink = new MrLink();
mrLink.OpenSafe();

Console.WriteLine("\nClient: Trying to access the safe with Mr. Proxy:");
MrProxy mrProxy = new MrProxy();
mrProxy.OpenSafe();
// Final Proxy