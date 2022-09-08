/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AsterLargeDetailInfo : MessageBase, IMessage<AsterLargeDetailInfo> // TypeDefIndex: 22001
{
	// Fields
	private static readonly MessageParser<AsterLargeDetailInfo> _parser; // 0x00
	public const int IsOpenFieldNumber = 1; // Metadata: 0x00B008B7
	private bool isOpen_; // 0x18
	public const int BeginTimeFieldNumber = 2; // Metadata: 0x00B008BB
	private uint beginTime_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AsterLargeDetailInfo> Parser { get => default; } // 0x0000000181DEF0E0-0x0000000181DEF170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181DEEE70-0x0000000181DEEF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181DEEB50-0x0000000181DEEBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181DEE570-0x0000000181DEE5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181DEF650-0x0000000181DEF740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181DEF340-0x0000000181DEF3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181DEEF00-0x0000000181DEEFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181DEF600-0x0000000181DEF650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181DEEC70-0x0000000181DEED60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x0000000181DEF3A0-0x0000000181DEF440 0x0000000181DEE5D0-0x0000000181DEE670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x0000000181DEF560-0x0000000181DEF600 0x0000000181DEF2A0-0x0000000181DEF340

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterLargeDetailInfo() {} // 0x0000000181DEFA00-0x0000000181DEFA60
	static AsterLargeDetailInfo() {} // 0x0000000181DEF940-0x0000000181DEFA00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterLargeDetailInfo Clone() => default; // 0x0000000181DEEFF0-0x0000000181DEF0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterLargeDetailInfo ShallowCopy() => default; // 0x0000000181DEEBD0-0x0000000181DEEC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181DEE7A0-0x0000000181DEE7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181DEF200-0x0000000181DEF250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181DEF250-0x0000000181DEF2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181DEE7F0-0x0000000181DEE860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181DEE860-0x0000000181DEE930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AsterLargeDetailInfo other) => default; // 0x0000000181DEE930-0x0000000181DEEA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181DEED60-0x0000000181DEEE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181DEF740-0x0000000181DEF940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181DEF440-0x0000000181DEF560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181DEEA50-0x0000000181DEEB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AsterLargeDetailInfo other) {} // 0x0000000181DEE670-0x0000000181DEE7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181DEE470-0x0000000181DEE570
}

