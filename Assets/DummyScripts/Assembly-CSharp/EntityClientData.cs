/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityClientData : MessageBase, IMessage<EntityClientData> // TypeDefIndex: 26092
{
	// Fields
	private static readonly MessageParser<EntityClientData> _parser; // 0x00
	public const int WindChangeSceneTimeFieldNumber = 1; // Metadata: 0x00B0B197
	private uint windChangeSceneTime_; // 0x18
	public const int WindmillSyncAngleFieldNumber = 2; // Metadata: 0x00B0B19B
	private float windmillSyncAngle_; // 0x1C
	public const int WindChangeTargetLevelFieldNumber = 3; // Metadata: 0x00B0B19F
	private int windChangeTargetLevel_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityClientData> Parser { get => default; } // 0x0000000181A8BD50-0x0000000181A8BDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A8B860-0x0000000181A8B8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A8B510-0x0000000181A8B590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A8AE80-0x0000000181A8AEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A8C1C0-0x0000000181A8C2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A8BFB0-0x0000000181A8C010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A8BAD0-0x0000000181A8BBC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A8C170-0x0000000181A8C1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A8B630-0x0000000181A8B720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WindChangeSceneTime { get => default; set {} } // 0x0000000181A8BCB0-0x0000000181A8BD50 0x0000000181A8BE70-0x0000000181A8BF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float WindmillSyncAngle { get => default; set {} } // 0x0000000181A8B8F0-0x0000000181A8B990 0x0000000181A8BA30-0x0000000181A8BAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int WindChangeTargetLevel { get => default; set {} } // 0x0000000181A8B990-0x0000000181A8BA30 0x0000000181A8B470-0x0000000181A8B510

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityClientData() {} // 0x0000000181A8C600-0x0000000181A8C660
	static EntityClientData() {} // 0x0000000181A8C540-0x0000000181A8C600

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityClientData Clone() => default; // 0x0000000181A8BBC0-0x0000000181A8BCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityClientData ShallowCopy() => default; // 0x0000000181A8B590-0x0000000181A8B630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A8B040-0x0000000181A8B090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A8BF10-0x0000000181A8BF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A8BF60-0x0000000181A8BFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A8B090-0x0000000181A8B110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A8B110-0x0000000181A8B1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityClientData other) => default; // 0x0000000181A8B1E0-0x0000000181A8B320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A8B720-0x0000000181A8B860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A8C2B0-0x0000000181A8C540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A8C010-0x0000000181A8C170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A8B320-0x0000000181A8B470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityClientData other) {} // 0x0000000181A8AEE0-0x0000000181A8B040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A8AD50-0x0000000181A8AE80
}

