
using System.Collections.Generic;

public class ByteArray // TypeDefIndex: 14762
{
    // Fields
    private static Queue<ByteArray> _pool; // 0x00
    public byte[] bytes; // 0x10
    public int pos; // 0x18
    private static byte[] byteBuf; // 0x08

    // Constructors
    public ByteArray(); // 0x0000000182289ED0-0x0000000182289F30
    static ByteArray(); // 0x0000000182289E40-0x0000000182289ED0

    // Methods
    [XID] // 0x00000001899B8C30-0x00000001899B8C50
    public static ByteArray Get(); // 0x0000000182289AF0-0x0000000182289C70
    [XID] // 0x00000001896908C0-0x00000001896908E0
    public static void Release(ByteArray byteArray); // 0x0000000182289C70-0x0000000182289D60
    [XID] // 0x0000000189698140-0x0000000189698160
    public static void InitBuf(); // 0x0000000182289D60-0x0000000182289E40
    [XID] // 0x000000018969F3E0-0x000000018969F400
    public bool movePosition(int distance); // 0x0000000182289860-0x0000000182289A10
    [XID] // 0x00000001896A67C0-0x00000001896A67E0
    public void Reset(); // 0x0000000182289A10-0x0000000182289AF0
}
