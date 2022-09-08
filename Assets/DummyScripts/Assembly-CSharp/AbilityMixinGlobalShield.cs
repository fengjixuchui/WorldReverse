/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMixinGlobalShield : MessageBase, IMessage<AbilityMixinGlobalShield> // TypeDefIndex: 21781
{
	// Fields
	private static readonly MessageParser<AbilityMixinGlobalShield> _parser; // 0x00
	public const int SubShieldFieldNumber = 1; // Metadata: 0x00AFFFC3
	private float subShield_; // 0x18
	public const int AvatarIdFieldNumber = 2; // Metadata: 0x00AFFFC7
	private uint avatarId_; // 0x1C
	public const int ShieldEffectNameFieldNumber = 3; // Metadata: 0x00AFFFCB
	private string shieldEffectName_; // 0x20
	public const int HeightOffsetFieldNumber = 4; // Metadata: 0x00AFFFCF
	private float heightOffset_; // 0x28
	public const int IsCreateEffectFieldNumber = 5; // Metadata: 0x00AFFFD3
	private bool isCreateEffect_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMixinGlobalShield> Parser { get => default; } // 0x0000000182832B50-0x0000000182832BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182832840-0x00000001828328D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001828323B0-0x0000000182832430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001828319C0-0x0000000182831A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182833250-0x0000000182833340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182832EF0-0x0000000182832F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182832970-0x0000000182832A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182833200-0x0000000182833250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001828324D0-0x00000001828325C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float SubShield { get => default; set {} } // 0x0000000182832DB0-0x0000000182832E50 0x0000000182832BE0-0x0000000182832C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x00000001828321D0-0x0000000182832270 0x0000000182832310-0x00000001828323B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ShieldEffectName { get => default; set {} } // 0x00000001828328D0-0x0000000182832970 0x0000000182831A20-0x0000000182831AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float HeightOffset { get => default; set {} } // 0x00000001828327A0-0x0000000182832840 0x0000000182832270-0x0000000182832310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsCreateEffect { get => default; set {} } // 0x0000000182832E50-0x0000000182832EF0 0x0000000182833160-0x0000000182833200

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinGlobalShield() {} // 0x0000000182833790-0x0000000182833800
	static AbilityMixinGlobalShield() {} // 0x00000001828336D0-0x0000000182833790

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinGlobalShield Clone() => default; // 0x0000000182832A60-0x0000000182832B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinGlobalShield ShallowCopy() => default; // 0x0000000182832430-0x00000001828324D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182831CB0-0x0000000182831D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182832D10-0x0000000182832D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182832D60-0x0000000182832DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182831D00-0x0000000182831DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182831DA0-0x0000000182831E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMixinGlobalShield other) => default; // 0x0000000182831E70-0x0000000182832030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001828325C0-0x00000001828327A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182833340-0x00000001828336D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182832F50-0x0000000182833160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182832030-0x00000001828321D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMixinGlobalShield other) {} // 0x0000000182831AD0-0x0000000182831CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182831830-0x00000001828319C0
}

