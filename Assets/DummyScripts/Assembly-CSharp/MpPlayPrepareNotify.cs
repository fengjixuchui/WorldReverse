/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MpPlayPrepareNotify : MessageBase, IMessage<MpPlayPrepareNotify> // TypeDefIndex: 24090
{
	// Fields
	private static readonly MessageParser<MpPlayPrepareNotify> _parser; // 0x00
	public const int MpPlayIdFieldNumber = 1; // Metadata: 0x00B0588B
	private uint mpPlayId_; // 0x18
	public const int PrepareEndTimeFieldNumber = 2; // Metadata: 0x00B0588F
	private uint prepareEndTime_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MpPlayPrepareNotify> Parser { get => default; } // 0x0000000182BAA790-0x0000000182BAA820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182BAA520-0x0000000182BAA5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182BAA0D0-0x0000000182BAA150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182BA9A20-0x0000000182BA9A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182BAAB20-0x0000000182BAAC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182BAA950-0x0000000182BAA9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182BAA5B0-0x0000000182BAA6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182BAAAD0-0x0000000182BAAB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182BAA1F0-0x0000000182BAA2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayId { get => default; set {} } // 0x0000000182BAA3E0-0x0000000182BAA480 0x0000000182BA9C70-0x0000000182BA9D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PrepareEndTime { get => default; set {} } // 0x0000000182BA9D10-0x0000000182BA9DB0 0x0000000182BAA480-0x0000000182BAA520

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24091
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24092
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1823
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayPrepareNotify() {} // 0x0000000182BAAED0-0x0000000182BAAF30
	static MpPlayPrepareNotify() {} // 0x0000000182BAAE10-0x0000000182BAAED0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayPrepareNotify Clone() => default; // 0x0000000182BAA6A0-0x0000000182BAA790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayPrepareNotify ShallowCopy() => default; // 0x0000000182BAA150-0x0000000182BAA1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182BA9BB0-0x0000000182BA9C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BAA8B0-0x0000000182BAA900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BAA900-0x0000000182BAA950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182BA9C00-0x0000000182BA9C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182BA9ED0-0x0000000182BA9FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MpPlayPrepareNotify other) => default; // 0x0000000182BA9DB0-0x0000000182BA9ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182BAA2E0-0x0000000182BAA3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182BAAC10-0x0000000182BAAE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182BAA9B0-0x0000000182BAAAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182BA9FA0-0x0000000182BAA0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MpPlayPrepareNotify other) {} // 0x0000000182BA9A80-0x0000000182BA9BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182BA9920-0x0000000182BA9A20
}

