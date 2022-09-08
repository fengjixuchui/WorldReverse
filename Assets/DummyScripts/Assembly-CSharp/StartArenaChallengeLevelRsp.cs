/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StartArenaChallengeLevelRsp : MessageBase, IMessage<StartArenaChallengeLevelRsp> // TypeDefIndex: 22245
{
	// Fields
	private static readonly MessageParser<StartArenaChallengeLevelRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01223
	private int retcode_; // 0x18
	public const int GadgetEntityIdFieldNumber = 2; // Metadata: 0x00B01227
	private uint gadgetEntityId_; // 0x1C
	public const int ArenaChallengeIdFieldNumber = 3; // Metadata: 0x00B0122B
	private uint arenaChallengeId_; // 0x20
	public const int ArenaChallengeLevelFieldNumber = 4; // Metadata: 0x00B0122F
	private uint arenaChallengeLevel_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<StartArenaChallengeLevelRsp> Parser { get => default; } // 0x0000000184875140-0x00000001848751D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184874ED0-0x0000000184874F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184874A20-0x0000000184874AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001848740F0-0x0000000184874150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184875690-0x0000000184875780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184875300-0x0000000184875360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184874F60-0x0000000184875050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184875640-0x0000000184875690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184874BE0-0x0000000184874CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184874980-0x0000000184874A20 0x00000001848744F0-0x0000000184874590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x0000000184875360-0x0000000184875400 0x0000000184874150-0x00000001848741F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ArenaChallengeId { get => default; set {} } // 0x0000000184874450-0x00000001848744F0 0x0000000184874E30-0x0000000184874ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ArenaChallengeLevel { get => default; set {} } // 0x0000000184874B40-0x0000000184874BE0 0x00000001848755A0-0x0000000184875640

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22246
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22247
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2196
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartArenaChallengeLevelRsp() {} // 0x0000000184875B60-0x0000000184875BC0
	static StartArenaChallengeLevelRsp() {} // 0x0000000184875AA0-0x0000000184875B60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartArenaChallengeLevelRsp Clone() => default; // 0x0000000184875050-0x0000000184875140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartArenaChallengeLevelRsp ShallowCopy() => default; // 0x0000000184874AA0-0x0000000184874B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184874370-0x00000001848743C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184875260-0x00000001848752B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848752B0-0x0000000184875300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001848743C0-0x0000000184874450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184874590-0x0000000184874660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(StartArenaChallengeLevelRsp other) => default; // 0x0000000184874660-0x00000001848747B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184874CD0-0x0000000184874E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184875780-0x0000000184875AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184875400-0x00000001848755A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001848747B0-0x0000000184874980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(StartArenaChallengeLevelRsp other) {} // 0x00000001848741F0-0x0000000184874370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184873FC0-0x00000001848740F0
}

