using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hometask_sem_2;

namespace Hometask_sem_2
{ };
class BitGetable
{
}

public interface IBitGetable
{
    bool GetBitByIndex(byte index);
    void SetBitByIndex(byte index, bool value);
}

public class Bits : IBitGetable  // internal class Bits : IBitGetable
{
    public long Value { get; private set; } //поменяли с: public byte Value { get; private set; }
                                            // свойство для неявного преобразования
    public byte ValueByte { get; private set; }
    public int ValueInt { get; private set; }
    private int Size { get; set; } //private
    public Bits(byte value)
    {
        Value = value;
        Size = sizeof(byte);
    }
    public Bits(int value)
    {
        Value = value;
        Size = sizeof(int);
    }
    public Bits(long value)
    {
        Value = value;
        Size = sizeof(long);
    }

    public bool GetBitByIndex(byte index) //     public bool GetBitByIndex(byte index)
    {
        return (Value & (1 << index)) != 0;
    }
    public void SetBitByIndex(byte index, bool value) //    public void SetBitByIndex(byte index, bool value)
    {
        if (value)
        {
            Value |= (byte)(1 << index);
        }
        else
        {
            Value &= (byte)~(1 << index);
        }
    }
    public bool this[byte index] //переопределение
    {
        get => GetBitByIndex(index);
        set => SetBitByIndex(index, value);
    }
    public static implicit operator long(Bits bits) => bits.Value; //неявное приведение переопределение было byte(Bits bits) => bits.Value;
    public static explicit operator Bits(long value) => new(value);//явное приведение переопределение Bits(byte value) => new(value)
    public static explicit operator Bits(byte value) => new(value);
    public static explicit operator Bits(int value) => new(value);

}