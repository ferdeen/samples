//<Snippet2>
// Example of the TimeSpan.Compare( TimeSpan, TimeSpan ) and 
// TimeSpan.Equals( TimeSpan, TimeSpan ) methods.
using System;

class TSCompareEqualsDemo
{
    const string dataFmt = "{0,-38}{1}" ;

    // Compare TimeSpan parameters, and display them with the results.
    static void CompareTimeSpans( TimeSpan Left, TimeSpan Right, 
        string RightText )
    {
        Console.WriteLine( );
        Console.WriteLine( dataFmt, "Right: " + RightText, Right );
        Console.WriteLine( dataFmt, "TimeSpan.Equals( Left, Right )", 
            TimeSpan.Equals( Left, Right ) );
        Console.WriteLine( dataFmt, 
            "TimeSpan.Compare( Left, Right )", 
            TimeSpan.Compare( Left, Right ) );
    }

    static void Main( )
    {
        TimeSpan Left = new TimeSpan( 2, 0, 0 );

        Console.WriteLine(
            "This example of the TimeSpan.Equals( TimeSpan, Time" +
            "Span ) and \nTimeSpan.Compare( TimeSpan, TimeSpan ) " +
            "methods generates the \nfollowing output by creating " +
            "several different TimeSpan \nobjects and comparing " +
            "them with a 2-hour TimeSpan.\n" );
        Console.WriteLine( dataFmt, "Left: TimeSpan( 2, 0, 0 )", 
            Left );

        // Create objects to compare with a 2-hour TimeSpan.
        CompareTimeSpans( Left, new TimeSpan( 0, 120, 0 ), 
            "TimeSpan( 0, 120, 0 )" );
        CompareTimeSpans( Left, new TimeSpan( 2, 0, 1 ), 
            "TimeSpan( 2, 0, 1 )" );
        CompareTimeSpans( Left, new TimeSpan( 2, 0, -1 ), 
            "TimeSpan( 2, 0, -1 )");
        CompareTimeSpans( Left, new TimeSpan( 72000000000 ), 
            "TimeSpan( 72000000000 )" );
        CompareTimeSpans( Left, TimeSpan.FromDays( 1.0 / 12D ), 
            "TimeSpan.FromDays( 1 / 12 )" );
    } 
} 

/*
This example of the TimeSpan.Equals( TimeSpan, TimeSpan ) and
TimeSpan.Compare( TimeSpan, TimeSpan ) methods generates the
following output by creating several different TimeSpan
objects and comparing them with a 2-hour TimeSpan.

Left: TimeSpan( 2, 0, 0 )             02:00:00

Right: TimeSpan( 0, 120, 0 )          02:00:00
TimeSpan.Equals( Left, Right )        True
TimeSpan.Compare( Left, Right )       0

Right: TimeSpan( 2, 0, 1 )            02:00:01
TimeSpan.Equals( Left, Right )        False
TimeSpan.Compare( Left, Right )       -1

Right: TimeSpan( 2, 0, -1 )           01:59:59
TimeSpan.Equals( Left, Right )        False
TimeSpan.Compare( Left, Right )       1

Right: TimeSpan( 72000000000 )        02:00:00
TimeSpan.Equals( Left, Right )        True
TimeSpan.Compare( Left, Right )       0

Right: TimeSpan.FromDays( 1 / 12 )    02:00:00
TimeSpan.Equals( Left, Right )        True
TimeSpan.Compare( Left, Right )       0
*/ 
//</Snippet2>
