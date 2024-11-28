### Overview:

You can use a large value like uint to store a binary number where each bit represents a 
Boolean. Sometimes you don't want a 1-to-1 correspondence, instead you may want a 2-to-1 correspondence where 2 bits = 1 value. This is where you would fragment the number into sections of bits to represent the different values. You can get 4 different values per pair out of a binary string this way ( 00, 01, 10, 11 ). To do this, we create an indexer which treats every 2 positions in a 64 character binary string as a single position. This is a type of proxy since the interface for accessing the value via index is the same, however internally we use bitwise operations to adjust the index to the correct position by doubling the value. Then we perform some additional magic for extraction. We use a mask and shift the mask to the correct index of the values we wish to extract from the original binary number. Finally, we extract the corresponding binary value using the bitwise & operator.

**Mathematical Problem In Proxy Example:**
- Suppose you have several different numbers, and you want to place different operators between the numbers to get different results. This proxy is used to cycle through several different combinations of mathematical operations. Each mathematical operation has a specific binary representation ( 00, 01, 11, 10 ). When the operations are extracted from a binary string, the sequence of operations is performed on the given set of numbers. When the resulting calculation performed matches a number from 0-10 it will display the equation discovered, in the order it was performed on the set of numbers, which resulted in the value.

**Binary Encoded Mathematical Operations:**
- Multiply = 00 = x
- Division = 01 = /
- Addition = 10 -= +
- Subtraction = 11 = -

**Number Set:**
- 1,3,5,7

**Binary Encoded Operational Equations Resulting in Desired Values:**
- 0 -> 1-3-5+7    //  11 11 10 
- 1 -> 1x3+5-7    //  00 10 11 
- 2 -> 1-3x5-7     //  11 00 11
- etc...

 **Information About Bit Shifting:**

- **Indexes** in a binary string start and move from right to left.
- **&** 
	- **AND**. A Bitwise operator that compares bits, side by side. Matching 1's give a 1, matching zeros and everything else gives us a 0.
- **|**
	- **OR** Operator. will give you a result if either one side or the other is set to 1.
- **^**
	- **XOR** Operator ( exclusive or ). requires each bit side by side to be specifically opposite. when one side is 0 the other HAS to be 1 and vice versa to get a 1. Otherwise you will get a zero.
- **~**
	- **Not** Operator. Works on a single value. Gives you the opposite of the current value.
- **<<**
	- Left Shift Operator. Multiplies by powers of 2 ( shifting left by `n`, is decimal# * `2^n`)
- **>>**
	- Right Shift Operator. Divides by powers of 2 ( shifting right by `n`, is decimal# / `2^n` )

**Binary String Fragmenting Example:**
- Ulong -> ...110001011000100101 -> 32 bits = 32 idxs [ bit 5 = idx 4 ]
- Pairs -> ...11 00 01 01 10 00 '10' 01 01 -> 16 pairs = 16 idxs [ bit 5&6 = idx2]

**Shifting and Indexes:**
- Shift Pair -> Shift '10' to the left 1 position
- Shift Value -> Index 2 << 1 position = index 3
- Shift Starting Index in Original Binary String = 4
- Shifting from index 2 to 3 in Fragmented Pairs means shifting values from idx 4 to 6 and 5 to 7 in Original Binary String.

**Extracting Value using a Mask:**
- **Mask** -> 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 **11** ( 0b11U )
- **Mask + Shift** ( resulting position = idx 4 )   = 00 00 00 00 00 00 00 00 00 00 00 00 00 **11** 00 00
- **Pairs**                                                              = 10 10 10 10 11 00 00 11 00 01 01 10 00 **10** 01 01
- **Mask & Data**                                                = 00 00 00 00 00 00 00 00 00 00 00 00 00 **10** 00 00 
- **Result + Shift Back**                                      = 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 **10**

**Calculating a Decimal Value In Binary:**
- Each bit in a binary number corresponds to a power of 2.
- The rightmost bit is the least significant bit (LSB) and represents 2^0
- As you move left, each bit represents increasing powers of 2.
- if a bit is a 1 then the corresponding power is it's value.
- if a bit is a 0 then the corresponding value is just 0.
- after you calculate the corresponding values, you add them all together to get the decimal value

**Binary Indexes and Corresponding Values:**
- index 0 = 2^0 = 1
- index 1 = 2^1 = 2
- index 2 = 2^2 = 4
- index 3 = 2^3 = 8
- index 4 = 2^4 = 16
- index 5 = 2^5 = 32
- index 6 = 2^6 = 64
- index 7 = 2^7 = 128
- etc.

**Shifting an Integer/Index:**
- When an integer is shifted 1 position to the left it is converted to binary, shifted 1 position left, and converted back to decimal. 1 positional shift left will effectively double the value of a decimal number. The reverse ( shifting right by 1 digit ) has the opposite effect by cutting the value in half. this works well when trying to extract a 2-bit chunk via an index. **```doubling the index ( index << 1 = index * 2^1 = index * 2 )```** will get the starting position of the value in a binary string. we then use the mask '11' and shift it to the starting position of the binary string. this overlaps the two bits next to each other we wish to extract we then perform the & bitwise operation to do so. A mask of 11 ensures we extract the correct bits ( see the & operator for clarification ).

### Types participating in this pattern include:


- **Problem**
	- The Problem Type contains a list of numbers used in the problem, as-well as a list of operations to perform. It also has an evaluation method which checks if certain operations are in the operational group. The operational group enforces we do mathematical operations in the correct order. In one opGroup Array is division and multiplication, the second group is addition and subtraction. This is how you would normally conduct these operations in math. The operations are then performed on the numbers in the group in a specific order. It mutates the numbers array as it performs the calculations it removes both numbers used in an operation, and replaces it with the resulting value. This continues until only the final result of all operations is completed and left as a single digit in the array. Additionally it checks for fractional results and automatically fails the operation, moving to the next operation, as we are only dealing with integers.
	
- **TwoBitSet**
	* The TwoBitSet Type makes use of an unsigned long value ( 64 bits ) which contains a binary number and treats it as a set of 2bit chunks ( 32 pairs ). It has an indexer, so we can access the value by index. It doubles the index value, since we are treating 2 bits as if they are a single value. So in order to extract the correct bits, we double the index to get the correct starting point. It then extracts the two bits at this starting point using a binary mask and performing a bitwise operation '&' between the data and the mask. It then shifts the bits back to the starting position and this result is converted to an operation that is listed in the enum. This indexer is the proxy. The indexer provides the same interface as a normal indexer would, however internally it returns a fragmented pair as if it were stored at the desired index by way of bit shifting.
	
- **OpImpl**
	- The OpImpl type is a class that maps Op values to operational names. It uses reflection to get the Op description attribute values and stores them in a dictionary alongside the actual operation names. It additionally contains behavior which will actually perform the operation described for each op name. This is stored in a second dictionary called opImpl.
	  Lastly, it contains two methods, one to retrieve the operations Name, and the other to call a specific operation to perform.
	
- **Op**
	- The Op Type is an Enum which contains the values that describe the types of mathematical operations we wish to perform and map it to a specific numerical value.

### Sources:
[Design Patterns in C# and .NET - Proxy: Bit Fragmenting](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)