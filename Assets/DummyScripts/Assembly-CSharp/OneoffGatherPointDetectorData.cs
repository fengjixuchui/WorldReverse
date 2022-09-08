/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OneoffGatherPointDetectorData : MessageBase, IMessage<OneoffGatherPointDetectorData> // TypeDefIndex: 25831
{
	// Fields
	private static readonly MessageParser<OneoffGatherPointDetectorData> _parser; // 0x00
	public const int MaterialIdFieldNumber = 1; // Metadata: 0x00B09A9B
	private uint materialId_; // 0x18
	public const int IsAllCollectedFieldNumber = 2; // Metadata: 0x00B09A9F
	private bool isAllCollected_; // 0x1C
	public const int IsHintValidFieldNumber = 3; // Metadata: 0x00B09AA3
	private bool isHintValid_; // 0x1D
	public const int HintCenterPosFieldNumber = 4; // Metadata: 0x00B09AA7
	private Vector hintCenterPos_; // 0x20
	public const int HintRadiusFieldNumber = 5; // Metadata: 0x00B09AAB
	private uint hintRadius_; // 0x28
	public const int GroupIdFieldNumber = 6; // Metadata: 0x00B09AAF
	private uint groupId_; // 0x2C
	public const int ConfigIdFieldNumber = 7; // Metadata: 0x00B09AB3
	private uint configId_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OneoffGatherPointDetectorData> Parser { get => default; } // 0x00000001811187A0-0x0000000181118830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001811182B0-0x0000000181118340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181117E40-0x0000000181117EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181117150-0x00000001811171B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181118F40-0x0000000181119030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181118C40-0x0000000181118CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181118520-0x0000000181118610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181118EF0-0x0000000181118F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181117F60-0x0000000181118050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaterialId { get => default; set {} } // 0x00000001811183E0-0x0000000181118480 0x0000000181118480-0x0000000181118520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAllCollected { get => default; set {} } // 0x0000000181118830-0x00000001811188D0 0x0000000181117D00-0x0000000181117DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsHintValid { get => default; set {} } // 0x0000000181118960-0x0000000181118A00 0x0000000181118BA0-0x0000000181118C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector HintCenterPos { get => default; set {} } // 0x0000000181118B00-0x0000000181118BA0 0x0000000181117250-0x00000001811172F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HintRadius { get => default; set {} } // 0x00000001811170B0-0x0000000181117150 0x0000000181117730-0x00000001811177D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x0000000181118610-0x00000001811186B0 0x0000000181117DA0-0x0000000181117E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x0000000181118340-0x00000001811183E0 0x00000001811171B0-0x0000000181117250

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OneoffGatherPointDetectorData() {} // 0x0000000181119590-0x00000001811195F0
	static OneoffGatherPointDetectorData() {} // 0x00000001811194D0-0x0000000181119590

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OneoffGatherPointDetectorData Clone() => default; // 0x00000001811186B0-0x00000001811187A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OneoffGatherPointDetectorData ShallowCopy() => default; // 0x0000000181117EC0-0x0000000181117F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181117540-0x00000001811175C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181118A00-0x0000000181118A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181118A80-0x0000000181118B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001811175C0-0x0000000181117730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001811177D0-0x00000001811178A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(OneoffGatherPointDetectorData other) => default; // 0x00000001811178A0-0x0000000181117A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181118050-0x00000001811182B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181119030-0x00000001811194D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181118CA0-0x0000000181118EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181117A70-0x0000000181117D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(OneoffGatherPointDetectorData other) {} // 0x00000001811172F0-0x0000000181117540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181116EE0-0x00000001811170B0
}

