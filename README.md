# Longest Increasing Subsequence Finder

## Introduction

This repository consists of functions designed to process a string input, which comprises a sequence of integers separated by a single whitespace. The primary objective is to identify and extract the longest increasing subsequence within this input. In cases where multiple sequences share the same maximum length, the function is designed to output the earliest one.

For Docker - "Running in Docker" under the "Usage" section, provides instructions on building and running the application within a Docker container.


## Getting Started

### Prerequisites

- .NET Core SDK
- Visual Studio or another preferred C# development environment

### Installation

Clone the repository:
   - git clone https://github.com/kodster/5e145d13-b4bd-483a-99e3-89fb6f9324dc.git
   - Open using Visaul Studio

## Usage

### Running Locally

- Run the application. F5 (or use the build file)
- Enter a sequence of integers separated by a single whitespace.
- To exit the program, type 'exit'.

### Running in Docker
	
If you have Docker installed, you can run the application in a Docker container:

Build the Docker image:
   `docker build -t longest-increasing-subsequence .`

   `docker run -it longest-increasing-subsequence`


### Exmaple
- Enter a sequence of integers separated by a single whitespace (or type 'exit' to quit): 6 1 5 9 2
- Output: 1 5 9 

## Tests
- Unit tests are included in the project to ensure the correctness of the implemented function. The test cases are defined in the testcases.json file. You can add more tests to this file or run the existing tests as part of the unit testing process.


## Dependencies
 - None.


## Deployments

- Currently only contains a build with  Continous Integration enabled.

