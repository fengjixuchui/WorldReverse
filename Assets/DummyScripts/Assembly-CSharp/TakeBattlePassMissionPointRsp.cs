/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeBattlePassMissionPointRsp : MessageBase, IMessage<TakeBattlePassMissionPointRsp> // TypeDefIndex: 22567
{
	// Fields
	private static readonly MessageParser<TakeBattlePassMissionPointRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01E27
	private int retcode_; // 0x18
	public const int MissionIdListFieldNumber = 2; // Metadata: 0x00B01E2B
	private static readonly FieldCodec<uint> _repeated_missionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> missionIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeBattlePassMissionPointRsp> Parser { get => default; } // 0x00000001822BB390-0x00000001822BB420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001822BB120-0x00000001822BB1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001822BAE10-0x00000001822BAE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001822BA690-0x00000001822BA6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001822BB740-0x00000001822BB830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001822BB550-0x00000001822BB5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001822BB1B0-0x00000001822BB2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001822BB6F0-0x00000001822BB740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001822BAF30-0x00000001822BB020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001822BAD70-0x00000001822BAE10 0x00000001822BA930-0x00000001822BA9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> MissionIdList { get => default; } // 0x00000001822BABD0-0x00000001822BAC30 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22568
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22569
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2608
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeBattlePassMissionPointRsp() {} // 0x00000001822BBAF0-0x00000001822BBB80
	static TakeBattlePassMissionPointRsp() {} // 0x00000001822BBA10-0x00000001822BBAF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeBattlePassMissionPointRsp Clone() => default; // 0x00000001822BB2A0-0x00000001822BB390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeBattlePassMissionPointRsp ShallowCopy() => default; // 0x00000001822BAE90-0x00000001822BAF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001822BA820-0x00000001822BA870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822BB4B0-0x00000001822BB500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822BB500-0x00000001822BB550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001822BA870-0x00000001822BA930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001822BAB00-0x00000001822BABD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeBattlePassMissionPointRsp other) => default; // 0x00000001822BA9D0-0x00000001822BAB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001822BB020-0x00000001822BB120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001822BB830-0x00000001822BBA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001822BB5B0-0x00000001822BB6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001822BAC30-0x00000001822BAD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeBattlePassMissionPointRsp other) {} // 0x00000001822BA6F0-0x00000001822BA820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001822BA520-0x00000001822BA690
}

