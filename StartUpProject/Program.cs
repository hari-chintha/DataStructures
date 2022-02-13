using DataStuctures.DynamicProgramming;

var fibRes = DynamicProgramming.Fib(8);
Console.WriteLine($"Fibanocci result - {fibRes}");

var countPathsResult = DynamicProgramming.CountPaths(DynamicProgramming.inputGrid,0,0,DynamicProgramming.paths);
Console.WriteLine($"Count Paths result: {countPathsResult}");


