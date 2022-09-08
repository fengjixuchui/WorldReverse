/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeBattlePassMissionPointReq : MessageBase, IMessage<TakeBattlePassMissionPointReq> // TypeDefIndex: 22564
{
	// Fields
	private static readonly MessageParser<TakeBattlePassMissionPointReq> _parser; // 0x00
	public const int MissionIdListFieldNumber = 1; // Metadata: 0x00B01E0F
	private static readonly FieldCodec<uint> _repeated_missionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> missionIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeBattlePassMissionPointReq> Parser { get => default; } // 0x000000018656DE00-0x000000018656DE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018656DB90-0x000000018656DC20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018656D8C0-0x000000018656D940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018656D320-0x000000018656D380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018656E170-0x000000018656E260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018656DFC0-0x000000018656E020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018656DC20-0x000000018656DD10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018656E120-0x000000018656E170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018656D9E0-0x000000018656DAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> MissionIdList { get => default; } // 0x000000018656D770-0x000000018656D7D0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22565
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22566
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2607
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeBattlePassMissionPointReq() {} // 0x000000018656E490-0x000000018656E520
	static TakeBattlePassMissionPointReq() {} // 0x000000018656E3B0-0x000000018656E490

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeBattlePassMissionPointReq Clone() => default; // 0x000000018656DD10-0x000000018656DE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeBattlePassMissionPointReq ShallowCopy() => default; // 0x000000018656D940-0x000000018656D9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018656D490-0x000000018656D4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018656DF20-0x000000018656DF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018656DF70-0x000000018656DFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018656D4E0-0x000000018656D5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018656D5A0-0x000000018656D670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeBattlePassMissionPointReq other) => default; // 0x000000018656D670-0x000000018656D770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018656DAD0-0x000000018656DB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018656E260-0x000000018656E3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018656E020-0x000000018656E120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018656D7D0-0x000000018656D8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeBattlePassMissionPointReq other) {} // 0x000000018656D380-0x000000018656D490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018656D1E0-0x000000018656D320
}

