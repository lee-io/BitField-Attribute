# BitField Attribute #
Enables bit field masking from the Inspector.

### Installation

Copy `BitFieldAttribute.cs` and the Editor folder containing `BitFieldAttributeDrawer.cs` to your Assets folder.

### Usage

Decorate your enumeration fields with the `[BitField]` attribute.

*Examples:*

    [Flags]
    public enum FlagsEnum
    {
      FLAG_1 = 1,
      FLAG_2 = 2,
      FLAG_3 = 4,
      FLAG_4 = 8
    }

    public enum Int32Enum : int
    {
      FLAG_1 = 1 << 0,
      FLAG_2 = 1 << 1,
      FLAG_3 = 1 << 2,
      FLAG_4 = 1 << 3
    }

    public enum ShortEnum : short
    {
      FLAG_1 = 0x1,
      FLAG_2 = 0x2,
      FLAG_3 = 0x4,
      FLAG_4 = 0x8
    }

    public enum SByteEnum : sbyte
    {
      FLAG_1 = 0x1,
      FLAG_2 = 0x2,
      FLAG_3 = 0x4,
      FLAG_4 = 0x8
    }

    [BitField]
    public FlagsEnum FlagsField;

    [BitField]
    public SByteEnum SByteField;

    [BitField]
    public ShortEnum ShortField;

    [BitField]
    public Int32Enum Int32Field;
    

### Limitations

Underlying types of unsigned integers or integers greater than 32bit are not support by the Unity Editor.

The fixed flag values are:
* Nothing = 0
* Everything = -1

### Preview
![picture alt](https://raw.githubusercontent.com/lee-io/Bitmask-Attribute/master/preview.png)
