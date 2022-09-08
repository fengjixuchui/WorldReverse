/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarDieAnimationEndRsp : MessageBase, IMessage<AvatarDieAnimationEndRsp> // TypeDefIndex: 22441
{
	// Fields
	private static readonly MessageParser<AvatarDieAnimationEndRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01963
	private int retcode_; // 0x18
	public const int DieGuidFieldNumber = 2; // Metadata: 0x00B01967
	private ulong dieGuid_; // 0x20
	public const int SkillIdFieldNumber = 3; // Metadata: 0x00B0196B
	private uint skillId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarDieAnimationEndRsp> Parser { get => default; } // 0x00000001823EE5A0-0x00000001823EE630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823EE1F0-0x00000001823EE280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001823EDD60-0x00000001823EDDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823ED600-0x00000001823ED660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823EE970-0x00000001823EEA60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001823EE760-0x00000001823EE7C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001823EE3C0-0x00000001823EE4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001823EE920-0x00000001823EE970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001823EDF20-0x00000001823EE010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001823EDCC0-0x00000001823EDD60 0x00000001823ED890-0x00000001823ED930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong DieGuid { get => default; set {} } // 0x00000001823EE150-0x00000001823EE1F0 0x00000001823EE320-0x00000001823EE3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillId { get => default; set {} } // 0x00000001823EDE80-0x00000001823EDF20 0x00000001823EE280-0x00000001823EE320

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22442
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22443
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1720
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarDieAnimationEndRsp() {} // 0x00000001823EEDB0-0x00000001823EEE10
	static AvatarDieAnimationEndRsp() {} // 0x00000001823EECF0-0x00000001823EEDB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarDieAnimationEndRsp Clone() => default; // 0x00000001823EE4B0-0x00000001823EE5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarDieAnimationEndRsp ShallowCopy() => default; // 0x00000001823EDDE0-0x00000001823EDE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823ED7C0-0x00000001823ED810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823EE6C0-0x00000001823EE710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823EE710-0x00000001823EE760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823ED810-0x00000001823ED890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001823EDA70-0x00000001823EDB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarDieAnimationEndRsp other) => default; // 0x00000001823ED930-0x00000001823EDA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001823EE010-0x00000001823EE150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001823EEA60-0x00000001823EECF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001823EE7C0-0x00000001823EE920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001823EDB40-0x00000001823EDCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarDieAnimationEndRsp other) {} // 0x00000001823ED660-0x00000001823ED7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001823ED4F0-0x00000001823ED600
}

