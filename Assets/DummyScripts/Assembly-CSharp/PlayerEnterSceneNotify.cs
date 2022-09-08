/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerEnterSceneNotify : MessageBase, IMessage<PlayerEnterSceneNotify> // TypeDefIndex: 24895
{
	// Fields
	private static readonly MessageParser<PlayerEnterSceneNotify> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B077D7
	private uint sceneId_; // 0x18
	public const int PosFieldNumber = 2; // Metadata: 0x00B077DB
	private Vector pos_; // 0x20
	public const int SceneBeginTimeFieldNumber = 3; // Metadata: 0x00B077DF
	private ulong sceneBeginTime_; // 0x28
	public const int TypeFieldNumber = 4; // Metadata: 0x00B077E3
	private EnterType type_; // 0x30
	public const int TargetUidFieldNumber = 6; // Metadata: 0x00B077E7
	private uint targetUid_; // 0x34
	public const int PrevSceneIdFieldNumber = 9; // Metadata: 0x00B077EB
	private uint prevSceneId_; // 0x38
	public const int PrevPosFieldNumber = 10; // Metadata: 0x00B077EF
	private Vector prevPos_; // 0x40
	public const int DungeonIdFieldNumber = 11; // Metadata: 0x00B077F3
	private uint dungeonId_; // 0x48
	public const int WorldLevelFieldNumber = 12; // Metadata: 0x00B077F7
	private uint worldLevel_; // 0x4C
	public const int EnterSceneTokenFieldNumber = 13; // Metadata: 0x00B077FB
	private uint enterSceneToken_; // 0x50
	public const int IsFirstLoginEnterSceneFieldNumber = 14; // Metadata: 0x00B077FF
	private bool isFirstLoginEnterScene_; // 0x54
	public const int SceneTagIdListFieldNumber = 15; // Metadata: 0x00B07803
	private static readonly FieldCodec<uint> _repeated_sceneTagIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> sceneTagIdList_; // 0x58
	public const int IsSkipUiFieldNumber = 16; // Metadata: 0x00B07807
	private bool isSkipUi_; // 0x60
	public const int EnterReasonFieldNumber = 17; // Metadata: 0x00B0780B
	private uint enterReason_; // 0x64

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerEnterSceneNotify> Parser { get => default; } // 0x0000000181F1C710-0x0000000181F1C7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181F1C220-0x0000000181F1C2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181F1B8C0-0x0000000181F1B940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181F1A480-0x0000000181F1A4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181F1D2F0-0x0000000181F1D3E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181F1CC30-0x0000000181F1CC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181F1C3F0-0x0000000181F1C4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181F1D200-0x0000000181F1D250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181F1BB20-0x0000000181F1BC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000181F1ADB0-0x0000000181F1AE50 0x0000000181F1B820-0x0000000181F1B8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000181F1C950-0x0000000181F1C9F0 0x0000000181F1D0C0-0x0000000181F1D160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong SceneBeginTime { get => default; set {} } // 0x0000000181F1D3E0-0x0000000181F1D480 0x0000000181F1B780-0x0000000181F1B820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterType Type { get => default; set {} } // 0x0000000181F1A0A0-0x0000000181F1A140 0x0000000181F1D250-0x0000000181F1D2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000181F1C040-0x0000000181F1C0E0 0x0000000181F1B6E0-0x0000000181F1B780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PrevSceneId { get => default; set {} } // 0x0000000181F1C670-0x0000000181F1C710 0x0000000181F1A9A0-0x0000000181F1AA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector PrevPos { get => default; set {} } // 0x0000000181F1C5D0-0x0000000181F1C670 0x0000000181F1D480-0x0000000181F1D520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x0000000181F1B9E0-0x0000000181F1BA80 0x0000000181F1D160-0x0000000181F1D200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WorldLevel { get => default; set {} } // 0x0000000181F1C350-0x0000000181F1C3F0 0x0000000181F1AD10-0x0000000181F1ADB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EnterSceneToken { get => default; set {} } // 0x0000000181F1C2B0-0x0000000181F1C350 0x0000000181F1CB90-0x0000000181F1CC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFirstLoginEnterScene { get => default; set {} } // 0x0000000181F1BA80-0x0000000181F1BB20 0x0000000181F1CA50-0x0000000181F1CAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> SceneTagIdList { get => default; } // 0x0000000181F1C9F0-0x0000000181F1CA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSkipUi { get => default; set {} } // 0x0000000181F1A4E0-0x0000000181F1A580 0x0000000181F1C180-0x0000000181F1C220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EnterReason { get => default; set {} } // 0x0000000181F1CAF0-0x0000000181F1CB90 0x0000000181F1C0E0-0x0000000181F1C180

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24896
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24897
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 201
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerEnterSceneNotify() {} // 0x0000000181F1DE30-0x0000000181F1DED0
	static PlayerEnterSceneNotify() {} // 0x0000000181F1DD50-0x0000000181F1DE30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerEnterSceneNotify Clone() => default; // 0x0000000181F1C4E0-0x0000000181F1C5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerEnterSceneNotify ShallowCopy() => default; // 0x0000000181F1B940-0x0000000181F1B9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181F1A910-0x0000000181F1A9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F1C830-0x0000000181F1C8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F1C8C0-0x0000000181F1C950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181F1AA40-0x0000000181F1AD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181F1B110-0x0000000181F1B1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerEnterSceneNotify other) => default; // 0x0000000181F1AE50-0x0000000181F1B110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181F1BC10-0x0000000181F1C040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181F1D520-0x0000000181F1DD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181F1CC90-0x0000000181F1D0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181F1B1E0-0x0000000181F1B6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerEnterSceneNotify other) {} // 0x0000000181F1A580-0x0000000181F1A910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181F1A140-0x0000000181F1A480
}

