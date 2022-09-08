/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarPropChangeReasonNotify : MessageBase, IMessage<AvatarPropChangeReasonNotify> // TypeDefIndex: 24549
{
	// Fields
	private static readonly MessageParser<AvatarPropChangeReasonNotify> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B06AF3
	private ulong avatarGuid_; // 0x18
	public const int PropTypeFieldNumber = 2; // Metadata: 0x00B06AF7
	private uint propType_; // 0x20
	public const int OldValueFieldNumber = 3; // Metadata: 0x00B06AFB
	private float oldValue_; // 0x24
	public const int CurValueFieldNumber = 4; // Metadata: 0x00B06AFF
	private float curValue_; // 0x28
	public const int ReasonFieldNumber = 5; // Metadata: 0x00B06B03
	private PropChangeReason reason_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarPropChangeReasonNotify> Parser { get => default; } // 0x0000000181AAE480-0x0000000181AAE510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181AADEF0-0x0000000181AADF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181AADAE0-0x0000000181AADB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181AAD090-0x0000000181AAD0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181AAE8E0-0x0000000181AAE9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181AAE640-0x0000000181AAE6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181AAE0C0-0x0000000181AAE1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181AAE890-0x0000000181AAE8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181AADC00-0x0000000181AADCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000181AADF80-0x0000000181AAE020 0x0000000181AAD2B0-0x0000000181AAD350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PropType { get => default; set {} } // 0x0000000181AAE340-0x0000000181AAE3E0 0x0000000181AAD580-0x0000000181AAD620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float OldValue { get => default; set {} } // 0x0000000181AAE020-0x0000000181AAE0C0 0x0000000181AADA40-0x0000000181AADAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float CurValue { get => default; set {} } // 0x0000000181AAE2A0-0x0000000181AAE340 0x0000000181AAD4E0-0x0000000181AAD580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PropChangeReason Reason { get => default; set {} } // 0x0000000181AAE3E0-0x0000000181AAE480 0x0000000181AAD3A0-0x0000000181AAD440

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24550
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24551
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1209
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarPropChangeReasonNotify() {} // 0x0000000181AAEE40-0x0000000181AAEEB0
	static AvatarPropChangeReasonNotify() {} // 0x0000000181AAED80-0x0000000181AAEE40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarPropChangeReasonNotify Clone() => default; // 0x0000000181AAE1B0-0x0000000181AAE2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarPropChangeReasonNotify ShallowCopy() => default; // 0x0000000181AADB60-0x0000000181AADC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181AAD350-0x0000000181AAD3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181AAE5A0-0x0000000181AAE5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181AAE5F0-0x0000000181AAE640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181AAD440-0x0000000181AAD4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181AAD7B0-0x0000000181AAD880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarPropChangeReasonNotify other) => default; // 0x0000000181AAD620-0x0000000181AAD7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181AADCF0-0x0000000181AADEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181AAE9D0-0x0000000181AAED80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181AAE6A0-0x0000000181AAE890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181AAD880-0x0000000181AADA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarPropChangeReasonNotify other) {} // 0x0000000181AAD0F0-0x0000000181AAD2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181AACF30-0x0000000181AAD090
}

