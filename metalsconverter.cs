using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DeathStrandingCalculator
{

    public static class MetalsConverter
    {
        //public double MetaltoPercent(int metals)
        //{
        //	return (metals / 15.0);   Roughly 15 metal per 1%
        //}

        public static string PrintAggregateList(List<int> amounts)
        {
            if (amounts == null || amounts.Count == 0)
                return "";
            System.Text.StringBuilder sb = new StringBuilder();
            amounts.Add(0);
            amounts.Sort();
            amounts.Reverse();

            int curr_amount = amounts[0];
            int i = 0;
            int x = 1;
            for (i = 1; i < amounts.Count; i++)
            {
                int this_amount = amounts[i];
                if (this_amount != curr_amount)
                {
                    sb.AppendLine($" {curr_amount} x {x}");
                    curr_amount = this_amount;
                    x = 1;
                }
                else
                {
                    x++;
                }
            }
            // amounts never changes
            if (x == i)
                sb.AppendLine($" {curr_amount} x {x}");
            // Last amount changed
            //if (amounts.Count >= 2 && amounts[amounts.Count - 1] != amounts[amounts.Count - 2])
            //    sb.AppendLine($" {amounts[amounts.Count - 1]} x 1");

            return sb.ToString();
        }

        public static string PrintAggregateList(List<int> amounts, ResourceType type)
        {
            StringBuilder sb = new StringBuilder();
            amounts.Add(0);
            amounts.Sort();
            amounts.Reverse();
            int x = 1;
            int i = 1;
            for (i = 1; i < amounts.Count; i++)
            {
                if (amounts[i - 1] != amounts[i])
                {
                    sb.AppendLine($" {amounts[i - 1]} x {x} {type}");
                    x = 1;
                }
                else
                {
                    x++;
                }
            }
            // amounts never changes
            if (x == i)
                sb.AppendLine($" {amounts[0]} x {x} {type}");
            // Last amount changed
            //if (amounts.Count > 2 && amounts[amounts.Count - 2] != amounts[amounts.Count - 1])
            //    sb.AppendLine($" {amounts[amounts.Count - 1]} x 1 {type}");
            return sb.ToString();
        }

        public static string PrintChunks(int amount, ResourceType type)
        {
            StringBuilder sb = new StringBuilder();
            List<int> chunkies = new List<int>();
            switch (type)
            {
                case ResourceType.Ceramic:
                    chunkies = CeramicChunks(amount);
                    break;
                case ResourceType.Metal:
                    chunkies = MetalChunks(amount);
                    break;
                case ResourceType.Chemical:
                    chunkies = ChemicalsChunks(amount);
                    break;
                case ResourceType.SpecialAlloy:
                    chunkies = SpecialAlloyChunks(amount);
                    break;
                default:
                    break;
            }
            foreach (int amt in chunkies)
            {
                sb.AppendLine($" {amt} of {type.ToString()}");
            }
            return sb.ToString();
        }

        public static string PrintChunksAggregate(int amount, ResourceType type)
        {
            List<int> chunkies = new List<int>();
            switch (type)
            {
                case ResourceType.Ceramic:
                    chunkies = CeramicChunks(amount);
                    break;
                case ResourceType.Metal:
                    chunkies = MetalChunks(amount);
                    break;
                case ResourceType.Chemical:
                    chunkies = ChemicalsChunks(amount);
                    break;
                case ResourceType.SpecialAlloy:
                    chunkies = SpecialAlloyChunks(amount);
                    break;
                default:
                    break;
            }
            return PrintAggregateList(chunkies, type);
        }

        public static void PrintChunksToFill(int maxamount, int currentamount, ResourceType type)
        {
            PrintChunks(maxamount - currentamount, type);
        }

        public static List<int> MetalChunks(int metalamount)
        {
            List<int> outputchunks = new List<int>();
            int[] chunk_amounts = new int[] {
        1000,
        800,
        600,
        400,
        200,
        100,
        50
    };
            outputchunks = Chunkify(metalamount, chunk_amounts);
            return outputchunks;
        }



        private static List<int> Chunkify(int amount, int[] chunks)
        {
            List<int> outputchunks = new List<int>();
            int remaining = amount;
            while (remaining > chunks[chunks.Length - 1])
            {
                for (int i = 0; i < chunks.Length; i++)
                {
                    if (remaining >= chunks[i])
                    {
                        remaining -= chunks[i];
                        outputchunks.Add(chunks[i]);
                        break;
                    }
                }
            }
            if (remaining != 0)
                outputchunks.Add(remaining);
            return outputchunks;
        }

        public static List<int> CeramicChunks(int ceramicamount)
        {
            List<int> outputchunks = new List<int>();
            int[] chunk_amounts = new int[] {
        800,
        640,
        480,
        320,
        160,
        80,
        40
    };
            outputchunks = Chunkify(ceramicamount, chunk_amounts);
            return outputchunks;
        }
        public static List<int> ChemicalsChunks(int ceramicamount)
        {
            List<int> outputchunks = new List<int>();
            int[] chunk_amounts = new int[] {
        600,
        480,
        360,
        240,
        120,
        60,
        30
    };
            outputchunks = Chunkify(ceramicamount, chunk_amounts);
            return outputchunks;
        }

        public static List<int> SpecialAlloyChunks(int ceramicamount)
        {
            List<int> outputchunks = new List<int>();
            int[] chunk_amounts = new int[] {
        1200,
        960,
        720,
        480,
        240,
        120,
        60
    };
            outputchunks = Chunkify(ceramicamount, chunk_amounts);
            return outputchunks;
        }

    }
}
