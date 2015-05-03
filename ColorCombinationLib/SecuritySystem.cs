using System.Collections.Generic;
using System.Text;

namespace ColorCombination
{
    public class SecuritySystem
    {
        private DirectedGraph dag;//directed acyclic graph
        private List<MyChip> chips;
        private List<MyChip> sortResults;
        private const string failureMsg = "Can not unlock master panel.";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inputChip"></param>
        public SecuritySystem(List<MyChip> inputChip)
        {
            if (ValidInput(inputChip))
            {
                chips = new List<MyChip>(inputChip);

                //modify the first chip and add the last chip
                var aChip = new MyChip { Left = chips[0].Right, Right = "" };
                chips.Add(aChip);
                chips[0].Right = chips[0].Left;
                chips[0].Left = "";

                //initiate the graph, calculate adjacent list
                dag = new DirectedGraph(chips.Count);
                dag.AddEdges(chips);
                sortResults = new List<MyChip>();
            }
        }

        /// <summary>
        /// to return a string with either color combination or failure message
        /// this method uses built-in chip color
        /// </summary>
        /// <returns></returns>
        public string FindMasterCombination()
        {
            //first check if there is a chip that can't point to other chips
            //due to some color that only appeared once 
            if (chips!=null && ValidColorCombination())
            {
                List<MyChip> chipsToSort = new List<MyChip>(chips);
                chipsToSort.RemoveAt(0);

                //find complete path, sortResults will be filled if there is a complete path
                FindCompletePath(chips[0], chipsToSort);

                //chips containes start chip, end chip and real chips
                //sortResults will have all chips except for the start chip, so the count number is one less.
                if (sortResults.Count == (chips.Count - 1))
                {
                    //found combination,return the combination
                    return PrintColorCombination();
                }

                    return failureMsg;
            }
            else
            {
                return failureMsg;
            }
        }

        /// <summary>
        /// Using graph's adjacent list to facilitate finding a color combination
        /// </summary>
        /// <returns></returns>
        public string FindMasterCombinationByG()
        {
            //first check if there is a chip that can't point to other chips
            //due to some color that only appeared once 
            if (chips!= null && ValidColorCombination())
            {
                Stack<int> completePath = new Stack<int>();
                completePath = dag.FindCompletePath();

                //make sure completePath is not null
                if (completePath != null && completePath.Count == chips.Count - 1)
                {
                    //in case you called the other findMasterCombination(), we need to clean up
                    if (sortResults.Count > 0) sortResults.Clear();

                    while (completePath.Count > 0)
                    {
                        sortResults.Add(chips[completePath.Pop()]);
                    }

                    return PrintColorCombination();
                }
                    return failureMsg;
            }
            else
            {
                return failureMsg;
            }
        }

        /// <summary>
        /// Validate input format, not implemented yet 
        /// </summary>
        /// <param name="inputChip"></param>
        /// <returns></returns>
        public bool ValidInput(List<MyChip> inputChip)
        {
            //TODO: Implement ValidInput
            if (inputChip == null || inputChip.Count < 2)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if the color combination might not work
        /// due to the color appearing only once
        /// Could be improved to check if one color appears different times between left and right
        /// </summary>
        /// <returns></returns>
        private bool ValidColorCombination()
        {
            //TODO: Complete ValidColorCombination
            for (int i = 0; i < (dag.adjacentList.Length) - 1; i++)
            {
                if (dag.adjacentList[i].Count == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Find complete path, called by findMasterCombination
        /// startChip should not be part of chipsToSort
        /// </summary>
        /// <param name="startChip"></param>
        /// <param name="chipsToSort"></param>
        private void FindCompletePath(MyChip startChip, List<MyChip> chipsToSort)
        {
            List<MyChip> currentList = new List<MyChip>(chipsToSort);

            //Brute-Force Search, not efficient, but works
            foreach (MyChip chip in currentList)
            {
                chipsToSort.Remove(chip);
                if (CompletePathFound(startChip, chip, chipsToSort)) return;
                //if a path not found, add the chip back to the list to be sorted
                chipsToSort.Add(chip);
            }
        }

        /// <summary>
        /// Called by findCompletePath(MyChip, List<MyChip>)
        /// if find a complete path, return true and sortResult will be filled
        /// if a complete path is not found, return false
        /// </summary>
        /// <param name="previous"></param>
        /// <param name="next"></param>
        /// <param name="remaining"></param>
        /// <returns></returns>
        private bool CompletePathFound(MyChip previous, MyChip next, List<MyChip> remaining)
        {
            if (previous.Right.Equals(next.Left))
            {
                return CompletePathFound(next, remaining);
            }
            else return false;
        }

        /// <summary>
        /// Called by completePathFound only if the previous chip can link to the next chip
        /// </summary>
        /// <param name="next"></param>
        /// <param name="remaining"></param>
        /// <returns></returns>
        private bool CompletePathFound(MyChip next, List<MyChip> remaining)
        {
            sortResults.Add(next);
            FindCompletePath(next, remaining);
            if (remaining.Count > 0)
            {
                //did not find the complete path
                sortResults.Remove(next);
                return false;
            }
                return true;
        }

        /// <summary>
        /// Map sortResults to a string for printing purpose
        /// </summary>
        /// <returns></returns>
        private string PrintColorCombination()
        {
            System.Console.WriteLine("Here is your master combination, please keep it safe.\n Do NOT WRITE DOWN ON A PIECE OF PAPER!");
            System.Console.WriteLine();
            sortResults.RemoveAt(sortResults.Count - 1);

            StringBuilder s = new StringBuilder();
            foreach (var t in sortResults)
            {
                s.AppendLine(t.Left + ", " + t.Right);
            }

            return s.ToString();
        }
    }
}
