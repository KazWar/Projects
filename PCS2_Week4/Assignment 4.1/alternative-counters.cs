using System;
using System.Collections;
using System.Linq;

// Numeric range
class Range
{
    public int From;
    public int To;
}


// Counter applicable for the specified numeric range
class Counter
{
    public Counter(int from, int to, int initialValue = 0)
    {
        this.Range = new Range() {
            From = from,
            To = to
        };
        this.Value = initialValue;
    }

    // Increases counter
    public int Increase(int by = 1) {
        this.Value = this.Value + by;
        return this.Value;
    }

    // Checks whether the counter is applicable for the specified value
    public bool InRange(int value) {
        return (value >= this.Range.From && value <= this.Range.To);
    }

    public readonly Range Range;
    public int Value;
}


// Counters
class Counters
{
    public Counters(Counter[] items) {
        this.Items = items;
    }

    // Increases the value of the applicable counter, returns it
    public Counter Increase(int value, int by = 1) {
        // Find the applicable counter
        var counter = this.Items.FirstOrDefault(item => item.InRange(value));
        if (counter == null) {
            throw new Exception("Counter not found for value " + value.ToString());
        }
        else {
            counter.Increase(by);
            return counter;
        }
    }

    public readonly Counter[] Items;
}


class Program {

    public static void Main() {
        Console.WriteLine("Yo, let's count.");

        var Counters = new Counters(new Counter[] {
            new Counter(0, 10),
            new Counter(11, 20),
            new Counter(21, 30)
        });

        Counter Counter = null;
        Counter = Counters.Increase(5);
        Counter = Counters.Increase(5);
        Counter = Counters.Increase(5);
        Console.WriteLine("5 => {0}", Counter.Value);

        Counter = Counters.Increase(15);
        Console.WriteLine("15 => {0}", Counter.Value);

        Counter = Counters.Increase(25);
        Counter = Counters.Increase(25);
        Counter = Counters.Increase(25);
        Counter = Counters.Increase(25);
        Console.WriteLine("25 => {0}", Counter.Value);

    }


}