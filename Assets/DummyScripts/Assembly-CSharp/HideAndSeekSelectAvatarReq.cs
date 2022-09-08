/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HideAndSeekSelectAvatarReq : MessageBase, IMessage<HideAndSeekSelectAvatarReq> // TypeDefIndex: 24178
{
	// Fields
	private static readonly MessageParser<HideAndSeekSelectAvatarReq> _parser; // 0x00
	public const int AvatarIdFieldNumber = 1; // Metadata: 0x00B05C8F
	private uint avatarId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HideAndSeekSelectAvatarReq> Parser { get => default; } // 0x00000001828E86C0-0x00000001828E8750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001828E8450-0x00000001828E84E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001828E8160-0x00000001828E81E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001828E7B30-0x00000001828E7B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001828E8A10-0x00000001828E8B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001828E8880-0x00000001828E88E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001828E84E0-0x00000001828E85D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001828E89C0-0x00000001828E8A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001828E8280-0x00000001828E8370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x00000001828E8020-0x00000001828E80C0 0x00000001828E80C0-0x00000001828E8160

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24179
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24180
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5344
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekSelectAvatarReq() {} // 0x00000001828E8D30-0x00000001828E8D90
	static HideAndSeekSelectAvatarReq() {} // 0x00000001828E8C70-0x00000001828E8D30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekSelectAvatarReq Clone() => default; // 0x00000001828E85D0-0x00000001828E86C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekSelectAvatarReq ShallowCopy() => default; // 0x00000001828E81E0-0x00000001828E8280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001828E7CA0-0x00000001828E7CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828E87E0-0x00000001828E8830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828E8830-0x00000001828E8880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001828E7CF0-0x00000001828E7D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001828E7E60-0x00000001828E7F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HideAndSeekSelectAvatarReq other) => default; // 0x00000001828E7D60-0x00000001828E7E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001828E8370-0x00000001828E8450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001828E8B00-0x00000001828E8C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001828E88E0-0x00000001828E89C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001828E7F30-0x00000001828E8020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HideAndSeekSelectAvatarReq other) {} // 0x00000001828E7B90-0x00000001828E7CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001828E7A50-0x00000001828E7B30
}

