

using System.Diagnostics.Metrics;
using hw5;
var counter=new Counter(100);
counter.Decrement();
counter.Decrement();
counter.Decrement();
counter.Decrement();
counter.PrintValue();
counter.Reset();
counter.PrintValue();