/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlockInfo : MessageBase, IMessage<BlockInfo> // TypeDefIndex: 26093
{
	// Fields
	private static readonly MessageParser<BlockInfo> _parser; // 0x00
	public const int BlockIdFieldNumber = 1; // Metadata: 0x00B0B1A3
	private uint blockId_; // 0x18
	public const int DataVersionFieldNumber = 2; // Metadata: 0x00B0B1A7
	private uint dataVersion_; // 0x1C
	public const int BinDataFieldNumber = 3; // Metadata: 0x00B0B1AB
	private ByteString binData_; // 0x20
	public const int IsDirtyFieldNumber = 4; // Metadata: 0x00B0B1AF
	private bool isDirty_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlockInfo> Parser { get => default; } // 0x00000001820E9330-0x00000001820E93C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001820E9020-0x00000001820E90B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001820E8BF0-0x00000001820E8C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001820E8380-0x00000001820E83E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001820E98A0-0x00000001820E9990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001820E9590-0x00000001820E95F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001820E90B0-0x00000001820E91A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001820E9850-0x00000001820E98A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001820E8D10-0x00000001820E8E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BlockId { get => default; set {} } // 0x00000001820E94F0-0x00000001820E9590 0x00000001820E95F0-0x00000001820E9690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DataVersion { get => default; set {} } // 0x00000001820E8F80-0x00000001820E9020 0x00000001820E9990-0x00000001820E9A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString BinData { get => default; set {} } // 0x00000001820E9290-0x00000001820E9330 0x00000001820E8620-0x00000001820E86D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsDirty { get => default; set {} } // 0x00000001820E9A30-0x00000001820E9AD0 0x00000001820E83E0-0x00000001820E8480

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlockInfo() {} // 0x00000001820E9E90-0x00000001820E9F20
	static BlockInfo() {} // 0x00000001820E9DD0-0x00000001820E9E90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlockInfo Clone() => default; // 0x00000001820E91A0-0x00000001820E9290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlockInfo ShallowCopy() => default; // 0x00000001820E8C70-0x00000001820E8D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001820E86D0-0x00000001820E8720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820E9450-0x00000001820E94A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820E94A0-0x00000001820E94F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001820E8720-0x00000001820E87E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001820E87E0-0x00000001820E88B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlockInfo other) => default; // 0x00000001820E88B0-0x00000001820E8A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001820E8E00-0x00000001820E8F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820E9AD0-0x00000001820E9DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820E9690-0x00000001820E9850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001820E8A40-0x00000001820E8BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlockInfo other) {} // 0x00000001820E8480-0x00000001820E8620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001820E8250-0x00000001820E8380
}

