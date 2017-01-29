﻿// https://trello.com/c/yiYX9kHq/210-counting-sheep

using System;

namespace Algorithms.CountSheep
{
    public static class CountSheepSolutionExample
    {
        public static void Run()
        {
            var inputList = new int[]
            {
                0,
                1,
                2,
                11,
                165,
                8,
                89,
                79,
                4,
                200,
                54,
                50,
                49,
                22,
                12,
                25,
                68,
                5,
                166,
                85,
                184,
                179,
                34,
                29,
                129,
                189,
                113,
                152,
                104,
                137,
                42,
                84,
                158,
                9,
                81,
                163,
                124,
                161,
                39,
                181,
                131,
                6,
                139,
                123,
                171,
                80,
                100,
                24,
                59,
                101,
                19,
                144,
                71,
                21,
                37,
                176,
                188,
                173,
                162,
                103,
                7,
                40,
                88,
                125,
                67,
                53,
                97,
                44,
                51,
                147,
                10,
                186,
                114,
                154,
                3,
                16,
                82,
                142,
                170,
                74,
                196,
                109,
                63,
                140,
                86,
                132,
                33,
                83,
                116,
                195,
                23,
                43,
                90,
                117,
                143,
                28,
                20,
                193,
                102,
                47
            };
            
            foreach (var i in inputList)
            {
                var result = CountSheep.GetLastSeenNumber(i);
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
