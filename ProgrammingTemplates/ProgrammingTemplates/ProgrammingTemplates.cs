// ------------------------------------------------------------------------
//     Copyright (c) 2026 @thatgato
// 
//     ProgrammingTemplates - ProgrammingTemplates.cs
// ------------------------------------------------------------------------

using System.Numerics;

namespace ProgrammingTemplates;

public static class Templates {
    static T SUM <T>( int start, int end, Func<int, T> incrFunc ) where T : INumber<T> {
        T sum = T.Zero;

        for ( int i = start; i < end; i++ )
        {
            sum += incrFunc( i );
        }

        return sum;
    }

    static int COUNT( int start, int end, Func<int, bool> predicateFunc ) {
        int count = 0;

        for ( int i = start; i < end; i++ )
        {
            if ( predicateFunc( i ) )
                count++;
        }

        return count;
    }

    static (int maxidx, T maxvalue) MAX <T>( int start, int end, Func<int, T> numFunc ) where T : INumber<T> {
        int maxidx   = 0;
        T   maxvalue = numFunc( start );

        for ( int i = start + 1; i < end; i++ )
        {
            if ( numFunc( i ) > maxvalue )
            {
                maxidx   = i;
                maxvalue = numFunc( i );
            }
        }

        return ( maxidx, maxvalue );
    }
}