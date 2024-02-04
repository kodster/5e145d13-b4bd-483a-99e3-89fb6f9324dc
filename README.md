# SequenceInsights Application

## Problem

This repository implements functions that takes a string input containing a sequence of integers separated by a single whitespace. The goal is to find the longest increasing subsequence present in that sequence. If multiple sequences have the same maximum length, the function should output the earliest one.

## Getting Started

### Prerequisites

- .NET Core SDK
- Visual Studio or another preferred C# development environment

### Installation

1. Clone the repository:
   git clone https://github.com/kodster/5e145d13-b4bd-483a-99e3-89fb6f9324dc.git

## Usage

- Run the application.
- Enter a sequence of integers separated by a single whitespace.
- To exit the program, type 'exit'.

### Example
`
var sequenceFinder = new SequenceFinder();
var input = "1 3 5 2 8 4 7";
var result = sequenceFinder.FindLongestIncreasingSubsequence(input);
Console.WriteLine("Longest Increasing Subsequence: " + string.Join(" ", result));
`

## Tests

 - Unit tests are included in the project to ensure the correctness of the implemented function. The test cases are defined in the testcases.json file. You can add more tests to this file or run the existing tests as part of the unit testing process.
