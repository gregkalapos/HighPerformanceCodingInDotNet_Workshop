using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using Demo3_BanchmarkDotNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

/// <summary>
/// This is the code of the second BenchmarkDotNet demo where we turn on MemoryDiagnoser 
/// and start our benchmark methods with 4 different GC settings
/// </summary>
namespace BenchmarkDotNetProject
{
	[MemoryDiagnoser] //Turn on MemoryDiagnoser to get the GC and allocation columns	
	public class Program
	{

		static IEnumerable<HistoricalQuote> HistoricalData;

		static Program()
		{
			HistoricalPriceReader hpr = new HistoricalPriceReader();
			HistoricalData = hpr.GetHistoricalQuotes("MSFT");
		}
		static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<Program>();
		}

		[Benchmark]
		public static void CalculateRsiOriginal()
		{
			var data = Rsi.CalculateRsi(HistoricalData, 14, CancellationToken.None);
			Debug.WriteLine(data.ToList().Count);
		}

		[Benchmark]
		public static void CalculateRsiFixed()
		{
			var dataFromFixed = Rsi.CalculateRsiFixed(HistoricalData, 14, CancellationToken.None);
			Debug.WriteLine(dataFromFixed.ToList().Count);
		}	
	}
}
