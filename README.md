WordSwapper
===========

Created by Ida Cervin. 

To run the program, build the WordSwapper solution (I've used Visual Studio 2017 Community Edition, NuGet restore is required to build the unit tests project) and then execute
> WordSwapper.exe Text.txt Dictionary.txt > Output.txt

or

> WordSwapper.exe Text.txt Dictionary.txt

to write the output to the console.

In the example above, Text.txt is the text that will have words swapped and Dictionary.txt is a dictionary where each line has the format "\<word to swap\>, \<replacement word\>".

Sample text and dictionary files are provided in the Samples folder. 

The program:
- swaps words regardless of upper case/lower case
- swaps to exactly the word in the dictionary (no changes in upper case/lower case)
- does not swap compound words. For example "offshore" is not swapped while "off" is swapped, if replacing the word "off"
- does not accept white spaces as words to be swapped or as replacements words. They are ignored and put to a separate dictionary of invalid words
