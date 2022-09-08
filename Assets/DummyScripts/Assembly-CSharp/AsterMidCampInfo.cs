/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AsterMidCampInfo : MessageBase, IMessage<AsterMidCampInfo> // TypeDefIndex: 21999
{
	// Fields
	private static readonly MessageParser<AsterMidCampInfo> _parser; // 0x00
	public const int CampIdFieldNumber = 1; // Metadata: 0x00B0089F
	private uint campId_; // 0x18
	public const int PosFieldNumber = 2; // Metadata: 0x00B008A3
	private Vector pos_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AsterMidCampInfo> Parser { get => default; } // 0x00000001848A53B0-0x00000001848A5440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001848A50A0-0x00000001848A5130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001848A4D10-0x00000001848A4D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001848A4540-0x00000001848A45A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001848A58E0-0x00000001848A59D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001848A5670-0x00000001848A56D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001848A5130-0x00000001848A5220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001848A5890-0x00000001848A58E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001848A4E30-0x00000001848A4F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CampId { get => default; set {} } // 0x00000001848A48D0-0x00000001848A4970 0x00000001848A5310-0x00000001848A53B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x00000001848A55D0-0x00000001848A5670 0x00000001848A57F0-0x00000001848A5890

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidCampInfo() {} // 0x00000001848A5C70-0x00000001848A5CD0
	static AsterMidCampInfo() {} // 0x00000001848A5BB0-0x00000001848A5C70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidCampInfo Clone() => default; // 0x00000001848A5220-0x00000001848A5310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidCampInfo ShallowCopy() => default; // 0x00000001848A4D90-0x00000001848A4E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001848A4720-0x00000001848A47A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848A54D0-0x00000001848A5550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848A5550-0x00000001848A55D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001848A47A0-0x00000001848A48D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001848A4970-0x00000001848A4A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AsterMidCampInfo other) => default; // 0x00000001848A4A40-0x00000001848A4B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001848A4F20-0x00000001848A50A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001848A59D0-0x00000001848A5BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001848A56D0-0x00000001848A57F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001848A4B70-0x00000001848A4D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AsterMidCampInfo other) {} // 0x00000001848A45A0-0x00000001848A4720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001848A4400-0x00000001848A4540
}

