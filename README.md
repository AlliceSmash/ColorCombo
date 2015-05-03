# Color Combination

#### Challenge
You recently had a state of the art security system installed in your home. The master control panel
requires a series of bi-colored chips to be placed end to end in a specific sequence in order to gain
access. The security provider split up the chips and gave a random number to each of your family
members. All of you must convene in order to assemble the chips and create the correct color
combination.

The access panel has a channel for the security chips. On each end of the channel is a colored marker.
Chips are placed end to end such that the adjacent colors match and the starting and ending chips are
color matched to the corresponding markers.

Write a program to see if the family has all the chips necessary to unlock the master control panel.

##### Input

It consists of a single line indicating the beginning and ending marker colors followed by a series
of chip definitions. All lines consist of a pair of color indicators; You may use integers, strings, or characters to represent each color. In this example, we will use strings.
##### Output

If the combination cannot be achieved by using all of the chips once and only once, then report “Cannot
unlock master panel”. If the combination can be achieved, then print the chips in the order required to
unlock the master control.

#### Solution Summary

This solution is implemented as a Class library run from MS visual studio unit tests. The test data include 6 examples.

The program includes 3 classes. MyChip class represents chip class with Left and Right properties (as color). DirectedGraph class represents a directed acyclic graph with a method to find a path from root (which is the startNode) to any vertex ( http://en.wikipedia.org/wiki/Directed_acyclic_graph ).  In this challenge, we only consider from root, the start chip, to the last vertex, that is, the last chip. SecuritySystem class is the main class to find color combination. It has a list of MyChip objects and a DirectedGraph object. 

To find the color combination, I implemented two methods in the SecuritySystem class.

**Method 1:** FindColorCombination(). It is a brute-force search. This method does not use DirectedGraph. It starts from the first chip and scan through each chip that is available (meaning waiting to be sorted out), with recursive calling between CompletePathFound() and FindCompletePath(). It uses a list to maintain the path from the starting chip to the end chip.

**Method 2:** FindColorCombinationByG(). This method is to call DirectedGraph and let it find a complete path from the starting chip to the end chip. It similarly uses brute-force search. But instead of scanning all chips, the graph itself has an adjacent list for each vertex (which represents each chip). The graph will only check a vertex on adjacent list to see if there is a complete path to the end vertex.

In both above methods, the SecuritySystem will check if the input panel has one chip (excluding starting and end chips) pointing to no where. If it is true, it will output the failure message. This can be improved by checking 1) if any color (excluding the two colors on both ends) appears same amount of time in Left and Right, and 2) the colors on both ends appear  odd number times. If the above statement is true, the SecuritySystem will continue to find the color combination, otherwise, it will output a failure message. 

**Note:**
The third example given in the test has multiple solutions. The program only outputs the first color combination it encounters.
