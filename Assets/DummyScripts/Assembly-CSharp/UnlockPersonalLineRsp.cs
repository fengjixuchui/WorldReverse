/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UnlockPersonalLineRsp : MessageBase, IMessage<UnlockPersonalLineRsp> // TypeDefIndex: 24686
{
	// Fields
	private static readonly MessageParser<UnlockPersonalLineRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06FEF
	private int retcode_; // 0x18
	public const int PersonalLineIdFieldNumber = 2; // Metadata: 0x00B06FF3
	private uint personalLineId_; // 0x1C
	public const int LevelFieldNumber = 3; // Metadata: 0x00B06FF7
	public const int ChapterIdFieldNumber = 4; // Metadata: 0x00B06FFB
	private object param_; // 0x20
	private ParamOneofCase paramCase_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UnlockPersonalLineRsp> Parser { get => default; } // 0x000000018353FBD0-0x000000018353FC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018353F900-0x000000018353F990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018353F4E0-0x000000018353F560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018353E9C0-0x000000018353EA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183540190-0x0000000183540280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018353FEE0-0x000000018353FF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018353F9F0-0x000000018353FAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183540140-0x0000000183540190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018353F6B0-0x000000018353F7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018353F440-0x000000018353F4E0 0x000000018353EE30-0x000000018353EED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PersonalLineId { get => default; set {} } // 0x000000018353FDF0-0x000000018353FE90 0x000000018353EED0-0x000000018353EF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x000000018353EBE0-0x000000018353ECB0 0x000000018353F600-0x000000018353F6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChapterId { get => default; set {} } // 0x000000018353F370-0x000000018353F440 0x000000018353FCF0-0x000000018353FDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ParamOneofCase ParamCase { get => default; } // 0x000000018353F990-0x000000018353F9F0 

	// Nested types
	public enum ParamOneofCase // TypeDefIndex: 24687
	{
		None = 0,
		Level = 3,
		ChapterId = 4
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24688
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24689
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 440
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockPersonalLineRsp() {} // 0x0000000183540690-0x0000000183540700
	static UnlockPersonalLineRsp() {} // 0x00000001835405D0-0x0000000183540690

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockPersonalLineRsp Clone() => default; // 0x000000018353FAE0-0x000000018353FBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockPersonalLineRsp ShallowCopy() => default; // 0x000000018353F560-0x000000018353F600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018353ED10-0x000000018353ED60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018353FDA0-0x000000018353FDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018353FE90-0x000000018353FEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018353ED60-0x000000018353EE30
	public void resetParam() {} // 0x00000001835400D0-0x0000000183540140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearParam() {} // 0x000000018353ECB0-0x000000018353ED10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018353F0E0-0x000000018353F1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UnlockPersonalLineRsp other) => default; // 0x000000018353EF70-0x000000018353F0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018353F7A0-0x000000018353F900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183540280-0x00000001835405D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018353FF40-0x00000001835400D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018353F1B0-0x000000018353F370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UnlockPersonalLineRsp other) {} // 0x000000018353EA20-0x000000018353EBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018353E890-0x000000018353E9C0
}

