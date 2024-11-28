namespace BitFragmentingProxy;

public class TwoBitSet
{
    // 64 bits --> 32 values
    private readonly ulong data;

    public TwoBitSet(ulong data)
    {
        this.data = data;
    }

    // The TwoBitSet class allows you to store 32 2-bit values in a 64-bit ulong,
    // and the indexer provides a way to access those 2-bit values by applying a mask
    // and shifting to isolate the correct 2-bit chunk. The mask and shifting mechanism
    // are used to extract the specific 2-bit value for a given index.
    // 11 in a bitwise operation will ensure all 1's and 0's are captured in the 2-bit chunk.
    public byte this[int index]
    {
        get
        {
            // Each bit in a binary number corresponds to a power of 2.
            // The rightmost bit is the least significant bit (LSB) and represents 2^0
            // As you move left, each bit represents increasing powers of 2.
            // if a bit is a 1 then the corresponding power is it's value.
            // if a bit is a 0 then the corresponding value is just 0.
            // after you calculate the corresponding values, you add them all together to get the decimal value

            // index 0 = 2^0 = 1
            // index 1 = 2^1 = 2
            // index 2 = 2^2 = 4
            // index 3 = 2^3 = 8
            // index 4 = 2^4 = 16
            // index 5 = 2^5 = 32
            // index 6 = 2^6 = 64
            // index 7 = 2^7 = 128
            // etc.
            
            // When an integer is shifted 1 position
            // it is converted to binary, shifted 1 position, and converted back to decimal.
            // 1 positional shift will effectively double the value of a decimal number 
            // this works well when trying to extract a 2-bit chunk.
            // doubling the index will get the starting position of the value in a binary string.
            // we then use the mask '11' and shift it to the starting position of the binary string.
            // this overlaps the two bits next to eachother we wish to extract
            // we then perform the bitwise operation to do so.

            var shift = index << 1;
            ulong mask = (0b11U << shift);
            return (byte)((data & mask) >> shift);
        }
    }
}