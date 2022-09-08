/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerGeneralMatchDismissNotify : MessageBase, IMessage<PlayerGeneralMatchDismissNotify> // TypeDefIndex: 23864
{
	// Fields
	private static readonly MessageParser<PlayerGeneralMatchDismissNotify> _parser; // 0x00
	public const int MatchIdFieldNumber = 1; // Metadata: 0x00B0502F
	private uint matchId_; // 0x18
	public const int ReasonFieldNumber = 2; // Metadata: 0x00B05033
	private MatchReason reason_; // 0x1C
	public const int UidListFieldNumber = 3; // Metadata: 0x00B05037
	private static readonly FieldCodec<uint> _repeated_uidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> uidList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerGeneralMatchDismissNotify> Parser { get => default; } // 0x00000001818B72E0-0x00000001818B7370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001818B6FD0-0x00000001818B7060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001818B6C50-0x00000001818B6CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001818B63F0-0x00000001818B6450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001818B7720-0x00000001818B7810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818B74A0-0x00000001818B7500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001818B7060-0x00000001818B7150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001818B7670-0x00000001818B76C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001818B6D70-0x00000001818B6E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MatchId { get => default; set {} } // 0x00000001818B6810-0x00000001818B68B0 0x00000001818B6450-0x00000001818B64F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MatchReason Reason { get => default; set {} } // 0x00000001818B7240-0x00000001818B72E0 0x00000001818B66A0-0x00000001818B6740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> UidList { get => default; } // 0x00000001818B76C0-0x00000001818B7720 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23865
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23866
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4163
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerGeneralMatchDismissNotify() {} // 0x00000001818B7B60-0x00000001818B7C00
	static PlayerGeneralMatchDismissNotify() {} // 0x00000001818B7A80-0x00000001818B7B60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerGeneralMatchDismissNotify Clone() => default; // 0x00000001818B7150-0x00000001818B7240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerGeneralMatchDismissNotify ShallowCopy() => default; // 0x00000001818B6CD0-0x00000001818B6D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001818B6650-0x00000001818B66A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818B7400-0x00000001818B7450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818B7450-0x00000001818B74A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818B6740-0x00000001818B6810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001818B69F0-0x00000001818B6AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerGeneralMatchDismissNotify other) => default; // 0x00000001818B68B0-0x00000001818B69F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001818B6E60-0x00000001818B6FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818B7810-0x00000001818B7A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001818B7500-0x00000001818B7670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001818B6AC0-0x00000001818B6C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerGeneralMatchDismissNotify other) {} // 0x00000001818B64F0-0x00000001818B6650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001818B6280-0x00000001818B63F0
}

