/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DraftOwnerTwiceConfirmNotify : MessageBase, IMessage<DraftOwnerTwiceConfirmNotify> // TypeDefIndex: 22785
{
	// Fields
	private static readonly MessageParser<DraftOwnerTwiceConfirmNotify> _parser; // 0x00
	public const int DraftIdFieldNumber = 1; // Metadata: 0x00B025CF
	private uint draftId_; // 0x18
	public const int TwiceConfirmDeadlineTimeFieldNumber = 2; // Metadata: 0x00B025D3
	private uint twiceConfirmDeadlineTime_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DraftOwnerTwiceConfirmNotify> Parser { get => default; } // 0x0000000185196B40-0x0000000185196BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001851968D0-0x0000000185196960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001851965C0-0x0000000185196640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185195E70-0x0000000185195ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185196F70-0x0000000185197060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185196DA0-0x0000000185196E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185196960-0x0000000185196A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185196F20-0x0000000185196F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001851966E0-0x00000001851967D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DraftId { get => default; set {} } // 0x00000001851960C0-0x0000000185196160 0x0000000185196CB0-0x0000000185196D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TwiceConfirmDeadlineTime { get => default; set {} } // 0x0000000185196480-0x0000000185196520 0x0000000185196520-0x00000001851965C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22786
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22787
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5410
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftOwnerTwiceConfirmNotify() {} // 0x0000000185197320-0x0000000185197380
	static DraftOwnerTwiceConfirmNotify() {} // 0x0000000185197260-0x0000000185197320

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftOwnerTwiceConfirmNotify Clone() => default; // 0x0000000185196A50-0x0000000185196B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftOwnerTwiceConfirmNotify ShallowCopy() => default; // 0x0000000185196640-0x00000001851966E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185196000-0x0000000185196050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185196C60-0x0000000185196CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185196D50-0x0000000185196DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185196050-0x00000001851960C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185196280-0x0000000185196350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DraftOwnerTwiceConfirmNotify other) => default; // 0x0000000185196160-0x0000000185196280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001851967D0-0x00000001851968D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185197060-0x0000000185197260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185196E00-0x0000000185196F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185196350-0x0000000185196480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DraftOwnerTwiceConfirmNotify other) {} // 0x0000000185195ED0-0x0000000185196000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185195D70-0x0000000185195E70
}

