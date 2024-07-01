using Timer;
using System.Diagnostics;


Globals.stopwatch = Stopwatch.StartNew();
Globals.stopwatch.Stop();
Renderer renderer = new Renderer();
renderer.Start().Wait();