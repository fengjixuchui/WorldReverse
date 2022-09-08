/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMixinAvatarSteerByCamera : MessageBase, IMessage<AbilityMixinAvatarSteerByCamera> // TypeDefIndex: 21776
{
	// Fields
	private static readonly MessageParser<AbilityMixinAvatarSteerByCamera> _parser; // 0x00
	public const int TargetPosFieldNumber = 1; // Metadata: 0x00AFFF97
	private Vector targetPos_; // 0x18
	public const int TargetDirFieldNumber = 2; // Metadata: 0x00AFFF9B
	private Vector targetDir_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMixinAvatarSteerByCamera> Parser { get => default; } // 0x0000000183E2D170-0x0000000183E2D200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E2CE60-0x0000000183E2CEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E2CA60-0x0000000183E2CAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183E2C050-0x0000000183E2C0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E2D570-0x0000000183E2D660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E2D3B0-0x0000000183E2D410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E2CF90-0x0000000183E2D080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E2D520-0x0000000183E2D570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E2CB80-0x0000000183E2CC70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector TargetPos { get => default; set {} } // 0x0000000183E2CEF0-0x0000000183E2CF90 0x0000000183E2C920-0x0000000183E2C9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector TargetDir { get => default; set {} } // 0x0000000183E2D660-0x0000000183E2D700 0x0000000183E2C9C0-0x0000000183E2CA60

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinAvatarSteerByCamera() {} // 0x0000000183E2D980-0x0000000183E2D9E0
	static AbilityMixinAvatarSteerByCamera() {} // 0x0000000183E2D8C0-0x0000000183E2D980

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinAvatarSteerByCamera Clone() => default; // 0x0000000183E2D080-0x0000000183E2D170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinAvatarSteerByCamera ShallowCopy() => default; // 0x0000000183E2CAE0-0x0000000183E2CB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E2C290-0x0000000183E2C320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E2D290-0x0000000183E2D320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E2D320-0x0000000183E2D3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183E2C320-0x0000000183E2C500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183E2C500-0x0000000183E2C5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMixinAvatarSteerByCamera other) => default; // 0x0000000183E2C5D0-0x0000000183E2C710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E2CC70-0x0000000183E2CE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E2D700-0x0000000183E2D8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E2D410-0x0000000183E2D520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E2C710-0x0000000183E2C920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMixinAvatarSteerByCamera other) {} // 0x0000000183E2C0B0-0x0000000183E2C290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E2BEE0-0x0000000183E2C050
}

