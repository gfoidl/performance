// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//

using BenchmarkDotNet.Attributes;
using MicroBenchmarks;

namespace Benchstone.BenchI
{
[BenchmarkCategory(Categories.Runtime, Categories.Benchstones, Categories.BenchI)]
public class Ackermann
{
    static int Acker(int m, int n) {
        if (m == 0) {
            return n + 1;
        }
        else if (n == 0) {
            return Acker(m - 1, 1);
        }
        else {
            return Acker(m - 1, Acker(m, n - 1));
        }
    }

    [Benchmark(Description = nameof(Ackermann))]
    public bool Test() {
        int a00 = Acker(0, 0);
        int a11 = Acker(1, 1);
        int a22 = Acker(2, 2);
        int a33 = Acker(3, 3);
        return (a00 == 1) && (a11 == 3) && (a22 == 7) & (a33 == 61);
    }
}
}
