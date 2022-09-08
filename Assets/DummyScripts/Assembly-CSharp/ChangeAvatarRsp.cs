/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChangeAvatarRsp : MessageBase, IMessage<ChangeAvatarRsp> // TypeDefIndex: 22405
{
	// Fields
	private static readonly MessageParser<ChangeAvatarRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01813
	private int retcode_; // 0x18
	public const int CurGuidFieldNumber = 2; // Metadata: 0x00B01817
	private ulong curGuid_; // 0x20
	public const int SkillIdFieldNumber = 3; // Metadata: 0x00B0181B
	private uint skillId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChangeAvatarRsp> Parser { get => default; } // 0x00000001837AE300-0x00000001837AE390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001837ADF50-0x00000001837ADFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001837ADB60-0x00000001837ADBE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001837AD400-0x00000001837AD460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001837AE770-0x00000001837AE860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001837AE4C0-0x00000001837AE520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001837AE080-0x00000001837AE170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001837AE720-0x00000001837AE770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001837ADD20-0x00000001837ADE10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001837ADAC0-0x00000001837ADB60 0x00000001837AD690-0x00000001837AD730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong CurGuid { get => default; set {} } // 0x00000001837AE520-0x00000001837AE5C0 0x00000001837AE260-0x00000001837AE300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillId { get => default; set {} } // 0x00000001837ADC80-0x00000001837ADD20 0x00000001837ADFE0-0x00000001837AE080

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22406
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22407
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1708
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeAvatarRsp() {} // 0x00000001837AEBB0-0x00000001837AEC10
	static ChangeAvatarRsp() {} // 0x00000001837AEAF0-0x00000001837AEBB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeAvatarRsp Clone() => default; // 0x00000001837AE170-0x00000001837AE260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeAvatarRsp ShallowCopy() => default; // 0x00000001837ADBE0-0x00000001837ADC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001837AD5C0-0x00000001837AD610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837AE420-0x00000001837AE470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837AE470-0x00000001837AE4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001837AD610-0x00000001837AD690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001837AD870-0x00000001837AD940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChangeAvatarRsp other) => default; // 0x00000001837AD730-0x00000001837AD870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001837ADE10-0x00000001837ADF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001837AE860-0x00000001837AEAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001837AE5C0-0x00000001837AE720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001837AD940-0x00000001837ADAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChangeAvatarRsp other) {} // 0x00000001837AD460-0x00000001837AD5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001837AD2F0-0x00000001837AD400
}

