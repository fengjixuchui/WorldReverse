/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayBattleInfo : MessageBase, IMessage<ScenePlayBattleInfo> // TypeDefIndex: 25365
{
	// Fields
	private static readonly MessageParser<ScenePlayBattleInfo> _parser; // 0x00
	public const int PlayIdFieldNumber = 1; // Metadata: 0x00B08903
	private uint playId_; // 0x18
	public const int PlayTypeFieldNumber = 2; // Metadata: 0x00B08907
	private uint playType_; // 0x1C
	public const int StateFieldNumber = 3; // Metadata: 0x00B0890B
	private uint state_; // 0x20
	public const int PrepareEndTimeFieldNumber = 4; // Metadata: 0x00B0890F
	private uint prepareEndTime_; // 0x24
	public const int StartTimeFieldNumber = 5; // Metadata: 0x00B08913
	private uint startTime_; // 0x28
	public const int DurationFieldNumber = 6; // Metadata: 0x00B08917
	private uint duration_; // 0x2C
	public const int ProgressStageListFieldNumber = 7; // Metadata: 0x00B0891B
	private static readonly FieldCodec<uint> _repeated_progressStageList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> progressStageList_; // 0x30
	public const int ProgressFieldNumber = 8; // Metadata: 0x00B0891F
	private uint progress_; // 0x38
	public const int ModeFieldNumber = 9; // Metadata: 0x00B08923
	private uint mode_; // 0x3C
	public const int TypeFieldNumber = 10; // Metadata: 0x00B08927
	private uint type_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayBattleInfo> Parser { get => default; } // 0x000000018416A9F0-0x000000018416AA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018416A640-0x000000018416A6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018416A000-0x000000018416A080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184169080-0x00000001841690E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018416B0E0-0x000000018416B1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018416ABB0-0x000000018416AC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018416A810-0x000000018416A900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018416AFF0-0x000000018416B040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018416A1C0-0x000000018416A2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayId { get => default; set {} } // 0x0000000184169F60-0x000000018416A000 0x000000018416A5A0-0x000000018416A640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayType { get => default; set {} } // 0x000000018416AC10-0x000000018416ACB0 0x0000000184169660-0x0000000184169700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint State { get => default; set {} } // 0x0000000184169E20-0x0000000184169EC0 0x0000000184169EC0-0x0000000184169F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PrepareEndTime { get => default; set {} } // 0x0000000184169700-0x00000001841697A0 0x000000018416A500-0x000000018416A5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartTime { get => default; set {} } // 0x000000018416B270-0x000000018416B310 0x000000018416A770-0x000000018416A810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Duration { get => default; set {} } // 0x000000018416B1D0-0x000000018416B270 0x00000001841690E0-0x0000000184169180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ProgressStageList { get => default; } // 0x0000000184169600-0x0000000184169660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Progress { get => default; set {} } // 0x000000018416A6D0-0x000000018416A770 0x000000018416A120-0x000000018416A1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Mode { get => default; set {} } // 0x0000000184168FE0-0x0000000184169080 0x0000000184169180-0x0000000184169220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Type { get => default; set {} } // 0x0000000184168CF0-0x0000000184168D90 0x000000018416B040-0x000000018416B0E0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleInfo() {} // 0x000000018416BA40-0x000000018416BAD0
	static ScenePlayBattleInfo() {} // 0x000000018416B960-0x000000018416BA40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleInfo Clone() => default; // 0x000000018416A900-0x000000018416A9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleInfo ShallowCopy() => default; // 0x000000018416A080-0x000000018416A120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184169480-0x00000001841694D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018416AB10-0x000000018416AB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018416AB60-0x000000018416ABB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001841694D0-0x0000000184169600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001841699C0-0x0000000184169A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayBattleInfo other) => default; // 0x00000001841697A0-0x00000001841699C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018416A2B0-0x000000018416A500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018416B310-0x000000018416B960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018416ACB0-0x000000018416AFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184169A90-0x0000000184169E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayBattleInfo other) {} // 0x0000000184169220-0x0000000184169480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184168D90-0x0000000184168FE0
}

