/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HideAndSeekSetReadyRsp : MessageBase, IMessage<HideAndSeekSetReadyRsp> // TypeDefIndex: 24187
{
	// Fields
	private static readonly MessageParser<HideAndSeekSetReadyRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05CD3
	private int retcode_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HideAndSeekSetReadyRsp> Parser { get => default; } // 0x0000000184BC7630-0x0000000184BC76C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184BC73C0-0x0000000184BC7450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184BC70D0-0x0000000184BC7150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184BC6AA0-0x0000000184BC6B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184BC7980-0x0000000184BC7A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184BC77F0-0x0000000184BC7850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184BC7450-0x0000000184BC7540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184BC7930-0x0000000184BC7980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184BC71F0-0x0000000184BC72E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184BC7030-0x0000000184BC70D0 0x0000000184BC6CD0-0x0000000184BC6D70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24188
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24189
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5347
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekSetReadyRsp() {} // 0x0000000184BC7CA0-0x0000000184BC7D00
	static HideAndSeekSetReadyRsp() {} // 0x0000000184BC7BE0-0x0000000184BC7CA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekSetReadyRsp Clone() => default; // 0x0000000184BC7540-0x0000000184BC7630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekSetReadyRsp ShallowCopy() => default; // 0x0000000184BC7150-0x0000000184BC71F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184BC6C10-0x0000000184BC6C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BC7750-0x0000000184BC77A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BC77A0-0x0000000184BC77F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184BC6C60-0x0000000184BC6CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184BC6D70-0x0000000184BC6E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HideAndSeekSetReadyRsp other) => default; // 0x0000000184BC6E40-0x0000000184BC6F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184BC72E0-0x0000000184BC73C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184BC7A70-0x0000000184BC7BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184BC7850-0x0000000184BC7930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184BC6F40-0x0000000184BC7030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HideAndSeekSetReadyRsp other) {} // 0x0000000184BC6B00-0x0000000184BC6C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184BC69C0-0x0000000184BC6AA0
}

