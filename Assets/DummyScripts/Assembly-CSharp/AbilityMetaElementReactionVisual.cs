/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMetaElementReactionVisual : MessageBase, IMessage<AbilityMetaElementReactionVisual> // TypeDefIndex: 21762
{
	// Fields
	private static readonly MessageParser<AbilityMetaElementReactionVisual> _parser; // 0x00
	public const int ElementReactionTypeFieldNumber = 1; // Metadata: 0x00AFFF2B
	private uint elementReactionType_; // 0x18
	public const int ElementSourceTypeFieldNumber = 2; // Metadata: 0x00AFFF2F
	private uint elementSourceType_; // 0x1C
	public const int ElementReactorTypeFieldNumber = 3; // Metadata: 0x00AFFF33
	private uint elementReactorType_; // 0x20
	public const int HitIndexFieldNumber = 4; // Metadata: 0x00AFFF37
	private int hitIndex_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMetaElementReactionVisual> Parser { get => default; } // 0x0000000183562990-0x0000000183562A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835625E0-0x0000000183562670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183562130-0x00000001835621B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183561940-0x00000001835619A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183562E40-0x0000000183562F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183562B50-0x0000000183562BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835627B0-0x00000001835628A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183562DF0-0x0000000183562E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183562250-0x0000000183562340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ElementReactionType { get => default; set {} } // 0x0000000183562540-0x00000001835625E0 0x0000000183561CA0-0x0000000183561D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ElementSourceType { get => default; set {} } // 0x0000000183562BB0-0x0000000183562C50 0x00000001835624A0-0x0000000183562540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ElementReactorType { get => default; set {} } // 0x0000000183561770-0x0000000183561810 0x0000000183562670-0x0000000183562710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int HitIndex { get => default; set {} } // 0x0000000183562710-0x00000001835627B0 0x00000001835619A0-0x0000000183561A40

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaElementReactionVisual() {} // 0x0000000183563310-0x0000000183563370
	static AbilityMetaElementReactionVisual() {} // 0x0000000183563250-0x0000000183563310

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaElementReactionVisual Clone() => default; // 0x00000001835628A0-0x0000000183562990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaElementReactionVisual ShallowCopy() => default; // 0x00000001835621B0-0x0000000183562250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183561BC0-0x0000000183561C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183562AB0-0x0000000183562B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183562B00-0x0000000183562B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183561C10-0x0000000183561CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183561E90-0x0000000183561F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMetaElementReactionVisual other) => default; // 0x0000000183561D40-0x0000000183561E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183562340-0x00000001835624A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183562F30-0x0000000183563250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183562C50-0x0000000183562DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183561F60-0x0000000183562130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMetaElementReactionVisual other) {} // 0x0000000183561A40-0x0000000183561BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183561810-0x0000000183561940
}

