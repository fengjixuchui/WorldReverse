/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UseMiracleRingRsp : MessageBase, IMessage<UseMiracleRingRsp> // TypeDefIndex: 23923
{
	// Fields
	private static readonly MessageParser<UseMiracleRingRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05243
	private int retcode_; // 0x18
	public const int MiracleRingOpTypeFieldNumber = 2; // Metadata: 0x00B05247
	private uint miracleRingOpType_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UseMiracleRingRsp> Parser { get => default; } // 0x0000000184C35CF0-0x0000000184C35D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184C359E0-0x0000000184C35A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184C356D0-0x0000000184C35750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184C35020-0x0000000184C35080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184C36120-0x0000000184C36210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184C35EB0-0x0000000184C35F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184C35B10-0x0000000184C35C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184C360D0-0x0000000184C36120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184C357F0-0x0000000184C358E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184C35630-0x0000000184C356D0 0x0000000184C35270-0x0000000184C35310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MiracleRingOpType { get => default; set {} } // 0x0000000184C36030-0x0000000184C360D0 0x0000000184C35A70-0x0000000184C35B10

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23924
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23925
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5202
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseMiracleRingRsp() {} // 0x0000000184C364D0-0x0000000184C36530
	static UseMiracleRingRsp() {} // 0x0000000184C36410-0x0000000184C364D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseMiracleRingRsp Clone() => default; // 0x0000000184C35C00-0x0000000184C35CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseMiracleRingRsp ShallowCopy() => default; // 0x0000000184C35750-0x0000000184C357F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184C351B0-0x0000000184C35200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C35E10-0x0000000184C35E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C35E60-0x0000000184C35EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184C35200-0x0000000184C35270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184C35310-0x0000000184C353E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UseMiracleRingRsp other) => default; // 0x0000000184C353E0-0x0000000184C35500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184C358E0-0x0000000184C359E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184C36210-0x0000000184C36410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184C35F10-0x0000000184C36030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184C35500-0x0000000184C35630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UseMiracleRingRsp other) {} // 0x0000000184C35080-0x0000000184C351B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184C34F20-0x0000000184C35020
}

