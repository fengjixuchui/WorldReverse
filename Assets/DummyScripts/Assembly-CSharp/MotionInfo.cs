/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MotionInfo : MessageBase, IMessage<MotionInfo> // TypeDefIndex: 26009
{
	// Fields
	private static readonly MessageParser<MotionInfo> _parser; // 0x00
	public const int PosFieldNumber = 1; // Metadata: 0x00B0AA73
	private Vector pos_; // 0x18
	public const int RotFieldNumber = 2; // Metadata: 0x00B0AA77
	private Vector rot_; // 0x20
	public const int SpeedFieldNumber = 3; // Metadata: 0x00B0AA7B
	private Vector speed_; // 0x28
	public const int StateFieldNumber = 4; // Metadata: 0x00B0AA7F
	private MotionState state_; // 0x30
	public const int ParamsFieldNumber = 5; // Metadata: 0x00B0AA83
	private static readonly FieldCodec<Vector> _repeated_params_codec; // 0x08
	private readonly RepeatedMessageField<Vector> params_; // 0x38
	public const int RefPosFieldNumber = 6; // Metadata: 0x00B0AA87
	private Vector refPos_; // 0x40
	public const int RefIdFieldNumber = 7; // Metadata: 0x00B0AA8B
	private uint refId_; // 0x48
	public const int SceneTimeFieldNumber = 8; // Metadata: 0x00B0AA8F
	private uint sceneTime_; // 0x4C
	public const int IntervalVelocityFieldNumber = 9; // Metadata: 0x00B0AA93
	private uint intervalVelocity_; // 0x50

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MotionInfo> Parser { get => default; } // 0x0000000182C32660-0x0000000182C326F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C32110-0x0000000182C321A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C31A20-0x0000000182C31AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C305A0-0x0000000182C30600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C32F30-0x0000000182C33020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C32A60-0x0000000182C32AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C323E0-0x0000000182C324D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C32E40-0x0000000182C32E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C31B40-0x0000000182C31C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000182C32920-0x0000000182C329C0 0x0000000182C32DA0-0x0000000182C32E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Rot { get => default; set {} } // 0x0000000182C32200-0x0000000182C322A0 0x0000000182C30600-0x0000000182C306A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Speed { get => default; set {} } // 0x0000000182C31980-0x0000000182C31A20 0x0000000182C32070-0x0000000182C32110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MotionState State { get => default; set {} } // 0x0000000182C317A0-0x0000000182C31840 0x0000000182C31840-0x0000000182C318E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Vector> Params { get => default; } // 0x0000000182C321A0-0x0000000182C32200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector RefPos { get => default; set {} } // 0x0000000182C32340-0x0000000182C323E0 0x0000000182C329C0-0x0000000182C32A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RefId { get => default; set {} } // 0x0000000182C33020-0x0000000182C330C0 0x0000000182C318E0-0x0000000182C31980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneTime { get => default; set {} } // 0x0000000182C322A0-0x0000000182C32340 0x0000000182C32E90-0x0000000182C32F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint IntervalVelocity { get => default; set {} } // 0x0000000182C30B00-0x0000000182C30BA0 0x0000000182C325C0-0x0000000182C32660

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MotionInfo() {} // 0x0000000182C33720-0x0000000182C337C0
	static MotionInfo() {} // 0x0000000182C33610-0x0000000182C33720

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MotionInfo Clone() => default; // 0x0000000182C324D0-0x0000000182C325C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MotionInfo ShallowCopy() => default; // 0x0000000182C31AA0-0x0000000182C31B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C30A40-0x0000000182C30B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C32780-0x0000000182C32850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C32850-0x0000000182C32920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C30BA0-0x0000000182C30FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C311F0-0x0000000182C312C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MotionInfo other) => default; // 0x0000000182C30FA0-0x0000000182C311F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C31C30-0x0000000182C32070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C330C0-0x0000000182C33610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C32AC0-0x0000000182C32DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C312C0-0x0000000182C317A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MotionInfo other) {} // 0x0000000182C306A0-0x0000000182C30A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C302B0-0x0000000182C305A0
}

