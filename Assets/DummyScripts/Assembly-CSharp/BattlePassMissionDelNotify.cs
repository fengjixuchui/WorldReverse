/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BattlePassMissionDelNotify : MessageBase, IMessage<BattlePassMissionDelNotify> // TypeDefIndex: 22551
{
	// Fields
	private static readonly MessageParser<BattlePassMissionDelNotify> _parser; // 0x00
	public const int DelMissionIdListFieldNumber = 1; // Metadata: 0x00B01DA7
	private static readonly FieldCodec<uint> _repeated_delMissionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> delMissionIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BattlePassMissionDelNotify> Parser { get => default; } // 0x00000001836B7E90-0x00000001836B7F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001836B7C20-0x00000001836B7CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001836B7950-0x00000001836B79D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001836B7410-0x00000001836B7470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001836B8260-0x00000001836B8350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001836B80B0-0x00000001836B8110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001836B7CB0-0x00000001836B7DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001836B8210-0x00000001836B8260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001836B7A70-0x00000001836B7B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> DelMissionIdList { get => default; } // 0x00000001836B8050-0x00000001836B80B0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22552
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22553
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2603
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassMissionDelNotify() {} // 0x00000001836B8580-0x00000001836B8610
	static BattlePassMissionDelNotify() {} // 0x00000001836B84A0-0x00000001836B8580

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassMissionDelNotify Clone() => default; // 0x00000001836B7DA0-0x00000001836B7E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassMissionDelNotify ShallowCopy() => default; // 0x00000001836B79D0-0x00000001836B7A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001836B7580-0x00000001836B75D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836B7FB0-0x00000001836B8000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836B8000-0x00000001836B8050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001836B75D0-0x00000001836B7690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001836B7690-0x00000001836B7760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BattlePassMissionDelNotify other) => default; // 0x00000001836B7760-0x00000001836B7860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001836B7B60-0x00000001836B7C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001836B8350-0x00000001836B84A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001836B8110-0x00000001836B8210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001836B7860-0x00000001836B7950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BattlePassMissionDelNotify other) {} // 0x00000001836B7470-0x00000001836B7580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836B72D0-0x00000001836B7410
}

