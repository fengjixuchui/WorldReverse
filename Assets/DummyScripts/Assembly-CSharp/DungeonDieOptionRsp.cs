/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonDieOptionRsp : MessageBase, IMessage<DungeonDieOptionRsp> // TypeDefIndex: 22843
{
	// Fields
	private static readonly MessageParser<DungeonDieOptionRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B02843
	private int retcode_; // 0x18
	public const int DieOptionFieldNumber = 2; // Metadata: 0x00B02847
	private PlayerDieOption dieOption_; // 0x1C
	public const int ReviveCountFieldNumber = 3; // Metadata: 0x00B0284B
	private uint reviveCount_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonDieOptionRsp> Parser { get => default; } // 0x0000000181D6FF10-0x0000000181D6FFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D6FC00-0x0000000181D6FC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D6F880-0x0000000181D6F900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D6F080-0x0000000181D6F0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D70420-0x0000000181D70510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D70170-0x0000000181D701D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D6FD30-0x0000000181D6FE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D703D0-0x0000000181D70420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D6F9A0-0x0000000181D6FA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181D6F7E0-0x0000000181D6F880 0x0000000181D6F310-0x0000000181D6F3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerDieOption DieOption { get => default; set {} } // 0x0000000181D6F740-0x0000000181D6F7E0 0x0000000181D701D0-0x0000000181D70270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ReviveCount { get => default; set {} } // 0x0000000181D6FC90-0x0000000181D6FD30 0x0000000181D700D0-0x0000000181D70170

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22844
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22845
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 913
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonDieOptionRsp() {} // 0x0000000181D70860-0x0000000181D70960
	static DungeonDieOptionRsp() {} // 0x0000000181D707A0-0x0000000181D70860

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonDieOptionRsp Clone() => default; // 0x0000000181D6FE20-0x0000000181D6FF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonDieOptionRsp ShallowCopy() => default; // 0x0000000181D6F900-0x0000000181D6F9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D6F240-0x0000000181D6F290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D70030-0x0000000181D70080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D70080-0x0000000181D700D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D6F290-0x0000000181D6F310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D6F4F0-0x0000000181D6F5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonDieOptionRsp other) => default; // 0x0000000181D6F3B0-0x0000000181D6F4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D6FA90-0x0000000181D6FC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D70510-0x0000000181D707A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D70270-0x0000000181D703D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D6F5C0-0x0000000181D6F740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonDieOptionRsp other) {} // 0x0000000181D6F0E0-0x0000000181D6F240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D6EF70-0x0000000181D6F080
}

