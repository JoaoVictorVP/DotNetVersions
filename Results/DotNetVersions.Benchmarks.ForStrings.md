``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 8.1 (6.3.9600.0)
Intel Core i5-3210M CPU 2.50GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
Frequency=2435884 Hz, Resolution=410.5286 ns, Timer=TSC
.NET SDK=7.0.100-preview.3.22179.4
  [Host]             : .NET 7.0.0 (7.0.22.17504), X64 RyuJIT
  DefaultJob         : .NET 7.0.0 (7.0.22.17504), X64 RyuJIT
  CoreRT 6.0         : .NET 6.0.0-rc.1.21420.1, X64 AOT
  .NET 6.0           : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4380.0), X64 RyuJIT
  .NET 5.0           : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT
  CoreRT 3.1         : .NET 6.0.0-rc.1.21420.1, X64 AOT
  .NET Core 3.1      : .NET Core 3.1.26 (CoreCLR 4.700.22.26002, CoreFX 4.700.22.26801), X64 RyuJIT


```
|                      Method |                Job |            Runtime |               Mean |             Error |             StdDev |             Median |      Gen 0 |      Gen 1 |      Gen 2 |     Allocated |
|---------------------------- |------------------- |------------------- |-------------------:|------------------:|-------------------:|-------------------:|-----------:|-----------:|-----------:|--------------:|
|                 FindIndexOf |         Job-IFVEFQ |               Mono |                 NA |                NA |                 NA |                 NA |          - |          - |          - |             - |
|                 FindIndexOf |         DefaultJob |           .NET 7.0 |     169,069.642 ns |     9,597.7478 ns |     26,111.3808 ns |     153,933.735 ns |          - |          - |          - |             - |
|                 FindIndexOf |         CoreRT 6.0 |         CoreRT 6.0 |     193,138.333 ns |    16,418.0186 ns |     48,151.2065 ns |     162,352.327 ns |          - |          - |          - |             - |
|                 FindIndexOf |           .NET 6.0 |           .NET 6.0 |     197,371.962 ns |    18,828.7248 ns |     55,516.9199 ns |     162,792.924 ns |          - |          - |          - |             - |
|                 FindIndexOf | .NET Framework 4.8 | .NET Framework 4.8 |     199,325.879 ns |    14,572.3009 ns |     41,810.6628 ns |     182,857.809 ns |          - |          - |          - |             - |
|                 FindIndexOf |           .NET 5.0 |           .NET 5.0 |     202,912.430 ns |    12,499.1175 ns |     36,657.7480 ns |     193,136.508 ns |          - |          - |          - |             - |
|                 FindIndexOf |         CoreRT 3.1 |         CoreRT 3.1 |     207,785.987 ns |    12,151.7341 ns |     35,254.3840 ns |     199,262.314 ns |          - |          - |          - |             - |
|                 FindIndexOf |      .NET Core 3.1 |      .NET Core 3.1 |     209,313.502 ns |    14,000.5011 ns |     41,061.0460 ns |     197,925.089 ns |          - |          - |          - |             - |
|                             |                    |                    |                    |                   |                    |                    |            |            |            |               |
|                     Replace |         Job-IFVEFQ |               Mono |                 NA |                NA |                 NA |                 NA |          - |          - |          - |             - |
|                     Replace |         CoreRT 6.0 |         CoreRT 6.0 |      20,701.069 ns |     1,645.6994 ns |      4,774.4724 ns |      17,643.496 ns |    22.2168 |          - |          - |      35,704 B |
|                     Replace |         CoreRT 3.1 |         CoreRT 3.1 |      23,080.552 ns |     1,522.6490 ns |      4,489.5649 ns |      21,990.622 ns |    22.2168 |          - |          - |      35,704 B |
|                     Replace |           .NET 6.0 |           .NET 6.0 |      23,491.396 ns |     1,875.3056 ns |      5,529.3810 ns |      22,351.332 ns |    22.2168 |          - |          - |      35,704 B |
|                     Replace |         DefaultJob |           .NET 7.0 |      25,414.866 ns |     1,862.9585 ns |      5,463.7347 ns |      23,710.656 ns |    22.2168 |          - |          - |      35,704 B |
|                     Replace |      .NET Core 3.1 |      .NET Core 3.1 |      72,948.176 ns |     2,807.9357 ns |      8,146.3307 ns |      71,090.726 ns |    22.2168 |          - |          - |      35,704 B |
|                     Replace |           .NET 5.0 |           .NET 5.0 |      73,768.116 ns |     3,448.2793 ns |     10,058.7925 ns |      71,143.470 ns |    22.2168 |          - |          - |      35,704 B |
|                     Replace | .NET Framework 4.8 | .NET Framework 4.8 |     169,556.420 ns |     5,651.2622 ns |     16,662.8740 ns |     165,222.970 ns |    22.2168 |          - |          - |      35,728 B |
|                             |                    |                    |                    |                   |                    |                    |            |            |            |               |
|                      Remove |         Job-IFVEFQ |               Mono |                 NA |                NA |                 NA |                 NA |          - |          - |          - |             - |
|                      Remove |         CoreRT 6.0 |         CoreRT 6.0 |      13,538.992 ns |     1,283.0442 ns |      3,783.0849 ns |      10,876.975 ns |    22.2168 |          - |          - |      35,680 B |
|                      Remove |           .NET 6.0 |           .NET 6.0 |      14,176.950 ns |       526.4461 ns |      1,501.9804 ns |      13,933.861 ns |    22.2168 |          - |          - |      35,680 B |
|                      Remove |         CoreRT 3.1 |         CoreRT 3.1 |      14,267.212 ns |       568.9172 ns |      1,641.4563 ns |      13,887.306 ns |    22.2168 |          - |          - |      35,680 B |
|                      Remove |           .NET 5.0 |           .NET 5.0 |      14,582.605 ns |       713.6399 ns |      2,059.0142 ns |      13,776.323 ns |    22.2168 |          - |          - |      35,680 B |
|                      Remove |      .NET Core 3.1 |      .NET Core 3.1 |      14,617.665 ns |       465.5892 ns |      1,358.1454 ns |      14,350.149 ns |    22.2168 |          - |          - |      35,680 B |
|                      Remove | .NET Framework 4.8 | .NET Framework 4.8 |      14,918.856 ns |       918.9297 ns |      2,665.9818 ns |      13,813.652 ns |    22.2168 |          - |          - |      35,704 B |
|                      Remove |         DefaultJob |           .NET 7.0 |      16,848.167 ns |     1,657.1823 ns |      4,886.2395 ns |      16,819.519 ns |    22.2168 |          - |          - |      35,680 B |
|                             |                    |                    |                    |                   |                    |                    |            |            |            |               |
|                    Contains |         Job-IFVEFQ |               Mono |                 NA |                NA |                 NA |                 NA |          - |          - |          - |             - |
|                    Contains |         DefaultJob |           .NET 7.0 |         880.944 ns |        36.8494 ns |        108.0729 ns |         857.692 ns |          - |          - |          - |             - |
|                    Contains |         CoreRT 6.0 |         CoreRT 6.0 |       2,775.227 ns |        17.5421 ns |         13.6957 ns |       2,770.006 ns |          - |          - |          - |             - |
|                    Contains |         CoreRT 3.1 |         CoreRT 3.1 |       3,457.633 ns |       131.0728 ns |        378.1751 ns |       3,416.464 ns |          - |          - |          - |             - |
|                    Contains |           .NET 6.0 |           .NET 6.0 |       3,677.296 ns |       155.7017 ns |        456.6460 ns |       3,617.085 ns |          - |          - |          - |             - |
|                    Contains |           .NET 5.0 |           .NET 5.0 |       3,689.696 ns |       136.0514 ns |        396.8685 ns |       3,640.954 ns |          - |          - |          - |             - |
|                    Contains |      .NET Core 3.1 |      .NET Core 3.1 |       3,949.440 ns |       168.4296 ns |        493.9748 ns |       3,806.624 ns |          - |          - |          - |             - |
|                    Contains | .NET Framework 4.8 | .NET Framework 4.8 |       4,644.765 ns |       246.8619 ns |        716.1910 ns |       4,441.734 ns |          - |          - |          - |             - |
|                             |                    |                    |                    |                   |                    |                    |            |            |            |               |
|                       Split |         Job-IFVEFQ |               Mono |                 NA |                NA |                 NA |                 NA |          - |          - |          - |             - |
|                       Split |         CoreRT 6.0 |         CoreRT 6.0 |     194,292.063 ns |     2,024.6675 ns |      4,486.5233 ns |     193,171.237 ns |    22.9492 |          - |          - |      36,112 B |
|                       Split |           .NET 5.0 |           .NET 5.0 |     201,658.268 ns |     5,818.2197 ns |     16,972.0201 ns |     200,334.088 ns |    22.9492 |          - |          - |      36,112 B |
|                       Split |         CoreRT 3.1 |         CoreRT 3.1 |     203,785.211 ns |     6,196.0635 ns |     17,877.0600 ns |     198,715.928 ns |    22.9492 |          - |          - |      36,112 B |
|                       Split |      .NET Core 3.1 |      .NET Core 3.1 |     207,934.147 ns |     4,974.5219 ns |     14,352.6331 ns |     203,482.410 ns |    22.9492 |          - |          - |      36,112 B |
|                       Split |           .NET 6.0 |           .NET 6.0 |     209,595.276 ns |     5,892.6266 ns |     17,189.0682 ns |     206,529.602 ns |    22.9492 |          - |          - |      36,112 B |
|                       Split |         DefaultJob |           .NET 7.0 |     221,642.736 ns |    10,316.8808 ns |     29,434.6415 ns |     221,052.903 ns |    22.9492 |          - |          - |      36,112 B |
|                       Split | .NET Framework 4.8 | .NET Framework 4.8 |     338,017.883 ns |    13,196.1891 ns |     37,862.3403 ns |     327,489.954 ns |    71.2891 |    17.5781 |          - |     179,471 B |
|                             |                    |                    |                    |                   |                    |                    |            |            |            |               |
|                   Substring |         Job-IFVEFQ |               Mono |                 NA |                NA |                 NA |                 NA |          - |          - |          - |             - |
|                   Substring |         CoreRT 6.0 |         CoreRT 6.0 |          44.954 ns |         4.4035 ns |         12.9838 ns |          39.846 ns |     0.0306 |          - |          - |          48 B |
|                   Substring |         CoreRT 3.1 |         CoreRT 3.1 |          48.229 ns |         3.4751 ns |         10.2465 ns |          45.549 ns |     0.0306 |          - |          - |          48 B |
|                   Substring |         DefaultJob |           .NET 7.0 |          48.669 ns |         5.1622 ns |         15.2209 ns |          44.786 ns |     0.0305 |          - |          - |          48 B |
|                   Substring |           .NET 6.0 |           .NET 6.0 |          49.329 ns |         4.5821 ns |         13.2935 ns |          44.681 ns |     0.0305 |          - |          - |          48 B |
|                   Substring | .NET Framework 4.8 | .NET Framework 4.8 |          51.439 ns |         3.4956 ns |         10.1967 ns |          51.193 ns |     0.0306 |          - |          - |          48 B |
|                   Substring |           .NET 5.0 |           .NET 5.0 |          52.570 ns |         3.4980 ns |         10.0926 ns |          50.027 ns |     0.0304 |          - |          - |          48 B |
|                   Substring |      .NET Core 3.1 |      .NET Core 3.1 |          58.484 ns |         4.2211 ns |         12.3798 ns |          56.241 ns |     0.0304 |          - |          - |          48 B |
|                             |                    |                    |                    |                   |                    |                    |            |            |            |               |
|           SubstringWithSpan |         Job-IFVEFQ |               Mono |                 NA |                NA |                 NA |                 NA |          - |          - |          - |             - |
|           SubstringWithSpan |         DefaultJob |           .NET 7.0 |           2.819 ns |         0.3621 ns |          1.0506 ns |           2.508 ns |          - |          - |          - |             - |
|           SubstringWithSpan |           .NET 6.0 |           .NET 6.0 |           3.081 ns |         0.4281 ns |          1.2555 ns |           2.695 ns |          - |          - |          - |             - |
|           SubstringWithSpan |         CoreRT 6.0 |         CoreRT 6.0 |           3.405 ns |         0.5044 ns |          1.4792 ns |           3.100 ns |          - |          - |          - |             - |
|           SubstringWithSpan |         CoreRT 3.1 |         CoreRT 3.1 |           3.586 ns |         0.2578 ns |          0.7271 ns |           3.422 ns |          - |          - |          - |             - |
|           SubstringWithSpan |      .NET Core 3.1 |      .NET Core 3.1 |           4.202 ns |         0.4015 ns |          1.1259 ns |           3.901 ns |          - |          - |          - |             - |
|           SubstringWithSpan |           .NET 5.0 |           .NET 5.0 |           4.402 ns |         0.4215 ns |          1.2296 ns |           4.003 ns |          - |          - |          - |             - |
|           SubstringWithSpan | .NET Framework 4.8 | .NET Framework 4.8 |          11.846 ns |         0.5961 ns |          1.6812 ns |          11.548 ns |          - |          - |          - |             - |
|                             |                    |                    |                    |                   |                    |                    |            |            |            |               |
|          IterateAndSumChars |         Job-IFVEFQ |               Mono |                 NA |                NA |                 NA |                 NA |          - |          - |          - |             - |
|          IterateAndSumChars |         CoreRT 6.0 |         CoreRT 6.0 |      14,102.104 ns |       340.3505 ns |        872.4485 ns |      13,574.091 ns |          - |          - |          - |             - |
|          IterateAndSumChars |         DefaultJob |           .NET 7.0 |      34,626.212 ns |     1,380.9307 ns |      4,050.0308 ns |      32,951.634 ns |          - |          - |          - |             - |
|          IterateAndSumChars |           .NET 5.0 |           .NET 5.0 |      36,904.870 ns |     1,168.3852 ns |      3,408.2345 ns |      36,269.476 ns |          - |          - |          - |             - |
|          IterateAndSumChars |         CoreRT 3.1 |         CoreRT 3.1 |      38,107.475 ns |     1,493.8196 ns |      4,357.5418 ns |      36,810.901 ns |          - |          - |          - |             - |
|          IterateAndSumChars |      .NET Core 3.1 |      .NET Core 3.1 |      38,338.899 ns |     1,352.5932 ns |      3,966.9216 ns |      37,158.524 ns |          - |          - |          - |             - |
|          IterateAndSumChars |           .NET 6.0 |           .NET 6.0 |      38,641.622 ns |     2,417.5044 ns |      7,090.1218 ns |      36,901.531 ns |          - |          - |          - |             - |
|          IterateAndSumChars | .NET Framework 4.8 | .NET Framework 4.8 |      44,362.790 ns |     1,352.4956 ns |      3,945.2933 ns |      43,108.533 ns |          - |          - |          - |             - |
|                             |                    |                    |                    |                   |                    |                    |            |            |            |               |
| IterateAndSumCharsUsingSpan |         Job-IFVEFQ |               Mono |                 NA |                NA |                 NA |                 NA |          - |          - |          - |             - |
| IterateAndSumCharsUsingSpan |         CoreRT 6.0 |         CoreRT 6.0 |      13,297.023 ns |       265.3732 ns |        504.9001 ns |      13,318.450 ns |          - |          - |          - |             - |
| IterateAndSumCharsUsingSpan |         DefaultJob |           .NET 7.0 |      33,080.454 ns |     1,218.6988 ns |      3,593.3609 ns |      30,298.733 ns |          - |          - |          - |             - |
| IterateAndSumCharsUsingSpan |         CoreRT 3.1 |         CoreRT 3.1 |      34,643.325 ns |     1,122.0663 ns |      3,290.8262 ns |      33,836.874 ns |          - |          - |          - |             - |
| IterateAndSumCharsUsingSpan |           .NET 5.0 |           .NET 5.0 |      34,783.787 ns |     1,299.2103 ns |      3,789.8575 ns |      33,937.125 ns |          - |          - |          - |             - |
| IterateAndSumCharsUsingSpan |      .NET Core 3.1 |      .NET Core 3.1 |      35,089.128 ns |     1,364.2891 ns |      4,022.6372 ns |      33,845.982 ns |          - |          - |          - |             - |
| IterateAndSumCharsUsingSpan |           .NET 6.0 |           .NET 6.0 |      43,018.765 ns |     3,612.0813 ns |     10,479.3027 ns |      41,477.306 ns |          - |          - |          - |             - |
| IterateAndSumCharsUsingSpan | .NET Framework 4.8 | .NET Framework 4.8 |      62,985.506 ns |     1,693.7799 ns |      4,832.4492 ns |      61,880.042 ns |          - |          - |          - |             - |
|                             |                    |                    |                    |                   |                    |                    |            |            |            |               |
|                   StringAdd |         Job-IFVEFQ |               Mono |                 NA |                NA |                 NA |                 NA |          - |          - |          - |             - |
|                   StringAdd |         CoreRT 6.0 |         CoreRT 6.0 | 126,485,407.110 ns | 2,467,326.7336 ns |  2,533,762.8994 ns | 126,358,233.808 ns | 19000.0000 | 19000.0000 | 19000.0000 | 180,322,866 B |
|                   StringAdd | .NET Framework 4.8 | .NET Framework 4.8 | 141,447,485.800 ns | 4,178,472.7152 ns | 12,320,321.0767 ns | 139,994,556.390 ns | 12250.0000 | 12250.0000 | 12250.0000 | 180,322,880 B |
|                   StringAdd |           .NET 5.0 |           .NET 5.0 | 153,441,916.954 ns | 9,200,568.3278 ns | 26,983,674.2269 ns | 151,419,224.670 ns | 10333.3333 | 10333.3333 | 10333.3333 | 180,322,264 B |
|                   StringAdd |      .NET Core 3.1 |      .NET Core 3.1 | 166,149,122.865 ns | 5,291,687.4754 ns | 15,602,659.9140 ns | 164,552,718.165 ns | 15000.0000 | 15000.0000 | 15000.0000 | 180,322,096 B |
|                   StringAdd |           .NET 6.0 |           .NET 6.0 | 168,839,572.671 ns | 8,684,953.8918 ns | 25,471,466.3421 ns | 167,972,387.028 ns | 15500.0000 | 15500.0000 | 15500.0000 | 180,327,378 B |
|                   StringAdd |         DefaultJob |           .NET 7.0 | 174,403,083.980 ns | 8,789,494.0918 ns | 25,778,064.6523 ns | 171,450,487.790 ns | 14500.0000 | 14500.0000 | 14500.0000 | 180,327,420 B |
|                   StringAdd |         CoreRT 3.1 |         CoreRT 3.1 | 296,651,549.564 ns | 6,283,794.1313 ns | 18,029,383.2998 ns | 296,246,455.085 ns | 13000.0000 | 13000.0000 | 13000.0000 | 180,322,776 B |
|                             |                    |                    |                    |                   |                    |                    |            |            |            |               |
|                StringConcat |         Job-IFVEFQ |               Mono |                 NA |                NA |                 NA |                 NA |          - |          - |          - |             - |
|                StringConcat |         CoreRT 6.0 |         CoreRT 6.0 |   2,429,006.779 ns |    44,260.3393 ns |     59,086.2817 ns |   2,436,443.825 ns |   296.8750 |   296.8750 |   296.8750 |   3,571,432 B |
|                StringConcat |      .NET Core 3.1 |      .NET Core 3.1 |   3,310,565.082 ns |    66,056.4470 ns |    127,268.3475 ns |   3,314,783.354 ns |   328.1250 |   328.1250 |   328.1250 |   3,571,416 B |
|                StringConcat | .NET Framework 4.8 | .NET Framework 4.8 |   3,646,958.705 ns |    70,490.3184 ns |     75,423.8510 ns |   3,645,561.946 ns |   328.1250 |   328.1250 |   328.1250 |   3,574,346 B |
|                StringConcat |         DefaultJob |           .NET 7.0 |   4,023,960.396 ns |    79,665.8112 ns |    149,631.7041 ns |   4,069,321.253 ns |   390.6250 |   390.6250 |   390.6250 |   3,571,549 B |
|                StringConcat |           .NET 6.0 |           .NET 6.0 |   4,037,756.897 ns |    99,578.6953 ns |    293,610.0299 ns |   4,015,865.942 ns |   312.5000 |   312.5000 |   312.5000 |   3,571,528 B |
|                StringConcat |           .NET 5.0 |           .NET 5.0 |   4,765,381.234 ns |    94,412.1447 ns |    152,458.0152 ns |   4,775,114.496 ns |   390.6250 |   390.6250 |   390.6250 |   3,571,415 B |
|                StringConcat |         CoreRT 3.1 |         CoreRT 3.1 |   5,635,093.045 ns |   112,161.4081 ns |    213,398.7358 ns |   5,579,939.742 ns |   359.3750 |   359.3750 |   359.3750 |   3,571,433 B |
|                             |                    |                    |                    |                   |                    |                    |            |            |            |               |
|                     ToUpper |         Job-IFVEFQ |               Mono |                 NA |                NA |                 NA |                 NA |          - |          - |          - |             - |
|                     ToUpper |         CoreRT 6.0 |         CoreRT 6.0 |      28,089.254 ns |     4,053.9827 ns |     11,953.2594 ns |      32,221.532 ns |    22.7203 |          - |          - |      35,736 B |
|                     ToUpper |           .NET 5.0 |           .NET 5.0 |      31,356.300 ns |       298.2386 ns |        232.8451 ns |      31,421.585 ns |    22.7051 |          - |          - |      35,736 B |
|                     ToUpper |      .NET Core 3.1 |      .NET Core 3.1 |      40,367.001 ns |     2,016.3558 ns |      5,913.6226 ns |      38,543.570 ns |    22.7051 |          - |          - |      35,736 B |
|                     ToUpper |           .NET 6.0 |           .NET 6.0 |      40,510.797 ns |     1,692.7961 ns |      4,937.9658 ns |      40,177.328 ns |    22.7051 |          - |          - |      35,736 B |
|                     ToUpper |         DefaultJob |           .NET 7.0 |      42,916.974 ns |     3,286.9486 ns |      9,691.6422 ns |      43,975.657 ns |    22.7051 |          - |          - |      35,736 B |
|                     ToUpper |         CoreRT 3.1 |         CoreRT 3.1 |      43,761.764 ns |     3,712.7361 ns |     10,947.0860 ns |      42,092.284 ns |    22.7051 |          - |          - |      35,736 B |
|                     ToUpper | .NET Framework 4.8 | .NET Framework 4.8 |     145,959.797 ns |     6,801.5950 ns |     19,624.1568 ns |     144,552.365 ns |    22.7051 |          - |          - |      35,768 B |
|                             |                    |                    |                    |                   |                    |                    |            |            |            |               |
|                     ToLower |         Job-IFVEFQ |               Mono |                 NA |                NA |                 NA |                 NA |          - |          - |          - |             - |
|                     ToLower |           .NET 5.0 |           .NET 5.0 |      36,025.274 ns |     2,346.5689 ns |      6,918.9114 ns |      31,628.729 ns |    22.7051 |          - |          - |      35,736 B |
|                     ToLower |           .NET 6.0 |           .NET 6.0 |      37,758.172 ns |     1,353.4805 ns |      3,905.1006 ns |      36,890.167 ns |    22.7051 |          - |          - |      35,736 B |
|                     ToLower |         CoreRT 3.1 |         CoreRT 3.1 |      38,991.062 ns |     2,565.0622 ns |      7,563.1438 ns |      36,777.325 ns |    22.7051 |          - |          - |      35,736 B |
|                     ToLower |         CoreRT 6.0 |         CoreRT 6.0 |      39,201.171 ns |     2,869.7564 ns |      8,461.5414 ns |      35,596.654 ns |    22.7051 |          - |          - |      35,736 B |
|                     ToLower |      .NET Core 3.1 |      .NET Core 3.1 |      40,654.331 ns |     2,152.5539 ns |      6,346.8537 ns |      38,344.883 ns |    22.7051 |          - |          - |      35,736 B |
|                     ToLower |         DefaultJob |           .NET 7.0 |      43,455.473 ns |     2,948.4402 ns |      8,693.5425 ns |      42,871.910 ns |    22.7051 |          - |          - |      35,736 B |
|                     ToLower | .NET Framework 4.8 | .NET Framework 4.8 |     151,862.603 ns |     8,615.7142 ns |     24,995.7492 ns |     147,600.008 ns |    22.7051 |          - |          - |      35,768 B |

Benchmarks with issues:
  ForStrings.FindIndexOf: Job-IFVEFQ(Runtime=Mono)
  ForStrings.Replace: Job-IFVEFQ(Runtime=Mono)
  ForStrings.Remove: Job-IFVEFQ(Runtime=Mono)
  ForStrings.Contains: Job-IFVEFQ(Runtime=Mono)
  ForStrings.Split: Job-IFVEFQ(Runtime=Mono)
  ForStrings.Substring: Job-IFVEFQ(Runtime=Mono)
  ForStrings.SubstringWithSpan: Job-IFVEFQ(Runtime=Mono)
  ForStrings.IterateAndSumChars: Job-IFVEFQ(Runtime=Mono)
  ForStrings.IterateAndSumCharsUsingSpan: Job-IFVEFQ(Runtime=Mono)
  ForStrings.StringAdd: Job-IFVEFQ(Runtime=Mono)
  ForStrings.StringConcat: Job-IFVEFQ(Runtime=Mono)
  ForStrings.ToUpper: Job-IFVEFQ(Runtime=Mono)
  ForStrings.ToLower: Job-IFVEFQ(Runtime=Mono)
