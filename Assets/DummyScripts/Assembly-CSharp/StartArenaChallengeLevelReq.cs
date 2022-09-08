/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StartArenaChallengeLevelReq : MessageBase, IMessage<StartArenaChallengeLevelReq> // TypeDefIndex: 22242
{
	// Fields
	private static readonly MessageParser<StartArenaChallengeLevelReq> _parser; // 0x00
	public const int GadgetEntityIdFieldNumber = 1; // Metadata: 0x00B01203
	private uint gadgetEntityId_; // 0x18
	public const int ArenaChallengeIdFieldNumber = 2; // Metadata: 0x00B01207
	private uint arenaChallengeId_; // 0x1C
	public const int ArenaChallengeLevelFieldNumber = 3; // Metadata: 0x00B0120B
	private uint arenaChallengeLevel_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<StartArenaChallengeLevelReq> Parser { get => default; } // 0x0000000182E320B0-0x0000000182E32140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182E31E40-0x0000000182E31ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182E319C0-0x0000000182E31A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182E31260-0x0000000182E312C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182E325C0-0x0000000182E326B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182E32270-0x0000000182E322D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182E31ED0-0x0000000182E31FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182E32570-0x0000000182E325C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182E31B80-0x0000000182E31C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x0000000182E322D0-0x0000000182E32370 0x0000000182E312C0-0x0000000182E31360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ArenaChallengeId { get => default; set {} } // 0x0000000182E31590-0x0000000182E31630 0x0000000182E31DA0-0x0000000182E31E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ArenaChallengeLevel { get => default; set {} } // 0x0000000182E31AE0-0x0000000182E31B80 0x0000000182E324D0-0x0000000182E32570

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22243
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22244
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2195
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartArenaChallengeLevelReq() {} // 0x0000000182E32A00-0x0000000182E32A60
	static StartArenaChallengeLevelReq() {} // 0x0000000182E32940-0x0000000182E32A00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartArenaChallengeLevelReq Clone() => default; // 0x0000000182E31FC0-0x0000000182E320B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartArenaChallengeLevelReq ShallowCopy() => default; // 0x0000000182E31A40-0x0000000182E31AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182E314C0-0x0000000182E31510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E321D0-0x0000000182E32220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E32220-0x0000000182E32270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182E31510-0x0000000182E31590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182E31630-0x0000000182E31700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(StartArenaChallengeLevelReq other) => default; // 0x0000000182E31700-0x0000000182E31840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182E31C70-0x0000000182E31DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182E326B0-0x0000000182E32940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182E32370-0x0000000182E324D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182E31840-0x0000000182E319C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(StartArenaChallengeLevelReq other) {} // 0x0000000182E31360-0x0000000182E314C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182E31150-0x0000000182E31260
}

