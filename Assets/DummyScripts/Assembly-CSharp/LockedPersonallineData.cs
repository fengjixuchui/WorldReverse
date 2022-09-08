/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LockedPersonallineData : MessageBase, IMessage<LockedPersonallineData> // TypeDefIndex: 24670
{
	// Fields
	private static readonly MessageParser<LockedPersonallineData> _parser; // 0x00
	public const int PersonalLineIdFieldNumber = 1; // Metadata: 0x00B06F5F
	private uint personalLineId_; // 0x18
	public const int LockReasonFieldNumber = 2; // Metadata: 0x00B06F63
	private Types.LockReason lockReason_; // 0x1C
	public const int ChapterIdFieldNumber = 3; // Metadata: 0x00B06F67
	public const int LevelFieldNumber = 4; // Metadata: 0x00B06F6B
	private object param_; // 0x20
	private ParamOneofCase paramCase_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<LockedPersonallineData> Parser { get => default; } // 0x0000000184E9C770-0x0000000184E9C800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184E9C400-0x0000000184E9C490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184E9BFB0-0x0000000184E9C030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184E9B5D0-0x0000000184E9B630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184E9CD30-0x0000000184E9CE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184E9CA80-0x0000000184E9CAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184E9C590-0x0000000184E9C680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184E9CCE0-0x0000000184E9CD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184E9C180-0x0000000184E9C270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PersonalLineId { get => default; set {} } // 0x0000000184E9C990-0x0000000184E9CA30 0x0000000184E9BA40-0x0000000184E9BAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.LockReason LockReason { get => default; set {} } // 0x0000000184E9C490-0x0000000184E9C530 0x0000000184E9CE20-0x0000000184E9CEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChapterId { get => default; set {} } // 0x0000000184E9BEE0-0x0000000184E9BFB0 0x0000000184E9C890-0x0000000184E9C940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000184E9B7F0-0x0000000184E9B8C0 0x0000000184E9C0D0-0x0000000184E9C180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ParamOneofCase ParamCase { get => default; } // 0x0000000184E9C530-0x0000000184E9C590 

	// Nested types
	public enum ParamOneofCase // TypeDefIndex: 24671
	{
		None = 0,
		ChapterId = 3,
		Level = 4
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24672
	{
		// Nested types
		public enum LockReason // TypeDefIndex: 24673
		{
			Level = 0,
			Quest = 1
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LockedPersonallineData() {} // 0x0000000184E9D2D0-0x0000000184E9D340
	static LockedPersonallineData() {} // 0x0000000184E9D210-0x0000000184E9D2D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LockedPersonallineData Clone() => default; // 0x0000000184E9C680-0x0000000184E9C770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LockedPersonallineData ShallowCopy() => default; // 0x0000000184E9C030-0x0000000184E9C0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184E9B920-0x0000000184E9B970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184E9C940-0x0000000184E9C990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184E9CA30-0x0000000184E9CA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184E9B970-0x0000000184E9BA40
	public void resetParam() {} // 0x0000000184E9CC70-0x0000000184E9CCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearParam() {} // 0x0000000184E9B8C0-0x0000000184E9B920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184E9BAE0-0x0000000184E9BBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(LockedPersonallineData other) => default; // 0x0000000184E9BBB0-0x0000000184E9BD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184E9C270-0x0000000184E9C400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184E9CEC0-0x0000000184E9D210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184E9CAE0-0x0000000184E9CC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184E9BD20-0x0000000184E9BEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(LockedPersonallineData other) {} // 0x0000000184E9B630-0x0000000184E9B7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184E9B4B0-0x0000000184E9B5D0
}

