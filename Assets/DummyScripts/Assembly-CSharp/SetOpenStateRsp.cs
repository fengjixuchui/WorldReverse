/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetOpenStateRsp : MessageBase, IMessage<SetOpenStateRsp> // TypeDefIndex: 24366
{
	// Fields
	private static readonly MessageParser<SetOpenStateRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06487
	private int retcode_; // 0x18
	public const int KeyFieldNumber = 2; // Metadata: 0x00B0648B
	private uint key_; // 0x1C
	public const int ValueFieldNumber = 3; // Metadata: 0x00B0648F
	private uint value_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetOpenStateRsp> Parser { get => default; } // 0x000000018166B8C0-0x000000018166B950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018166B5B0-0x000000018166B640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018166B270-0x000000018166B2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018166AA70-0x000000018166AAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018166BD30-0x000000018166BE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018166BB20-0x000000018166BB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018166B6E0-0x000000018166B7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018166BCE0-0x000000018166BD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018166B390-0x000000018166B480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018166B1D0-0x000000018166B270 0x000000018166ADA0-0x000000018166AE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Key { get => default; set {} } // 0x000000018166BE20-0x000000018166BEC0 0x000000018166AAD0-0x000000018166AB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Value { get => default; set {} } // 0x000000018166B640-0x000000018166B6E0 0x000000018166BA30-0x000000018166BAD0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24367
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24368
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 123
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetOpenStateRsp() {} // 0x000000018166C210-0x000000018166C270
	static SetOpenStateRsp() {} // 0x000000018166C150-0x000000018166C210

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetOpenStateRsp Clone() => default; // 0x000000018166B7D0-0x000000018166B8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetOpenStateRsp ShallowCopy() => default; // 0x000000018166B2F0-0x000000018166B390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018166ACD0-0x000000018166AD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018166B9E0-0x000000018166BA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018166BAD0-0x000000018166BB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018166AD20-0x000000018166ADA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018166AF80-0x000000018166B050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetOpenStateRsp other) => default; // 0x000000018166AE40-0x000000018166AF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018166B480-0x000000018166B5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018166BEC0-0x000000018166C150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018166BB80-0x000000018166BCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018166B050-0x000000018166B1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetOpenStateRsp other) {} // 0x000000018166AB70-0x000000018166ACD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018166A960-0x000000018166AA70
}

