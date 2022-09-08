/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BackMyWorldRsp : MessageBase, IMessage<BackMyWorldRsp> // TypeDefIndex: 25127
{
	// Fields
	private static readonly MessageParser<BackMyWorldRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B080C3
	private int retcode_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BackMyWorldRsp> Parser { get => default; } // 0x0000000180CB4000-0x0000000180CB4090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180CB3D90-0x0000000180CB3E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180CB3AA0-0x0000000180CB3B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180CB3470-0x0000000180CB34D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180CB4350-0x0000000180CB4440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180CB41C0-0x0000000180CB4220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180CB3E20-0x0000000180CB3F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180CB4300-0x0000000180CB4350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180CB3BC0-0x0000000180CB3CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000180CB3A00-0x0000000180CB3AA0 0x0000000180CB36A0-0x0000000180CB3740

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25128
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25129
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 276
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BackMyWorldRsp() {} // 0x0000000180CB4670-0x0000000180CB46D0
	static BackMyWorldRsp() {} // 0x0000000180CB45B0-0x0000000180CB4670

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BackMyWorldRsp Clone() => default; // 0x0000000180CB3F10-0x0000000180CB4000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BackMyWorldRsp ShallowCopy() => default; // 0x0000000180CB3B20-0x0000000180CB3BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180CB35E0-0x0000000180CB3630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180CB4120-0x0000000180CB4170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180CB4170-0x0000000180CB41C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180CB3630-0x0000000180CB36A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180CB3740-0x0000000180CB3810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BackMyWorldRsp other) => default; // 0x0000000180CB3810-0x0000000180CB3910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180CB3CB0-0x0000000180CB3D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180CB4440-0x0000000180CB45B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180CB4220-0x0000000180CB4300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180CB3910-0x0000000180CB3A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BackMyWorldRsp other) {} // 0x0000000180CB34D0-0x0000000180CB35E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180CB3390-0x0000000180CB3470
}

