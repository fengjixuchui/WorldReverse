/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetPlayerSignatureReq : MessageBase, IMessage<SetPlayerSignatureReq> // TypeDefIndex: 25570
{
	// Fields
	private static readonly MessageParser<SetPlayerSignatureReq> _parser; // 0x00
	public const int SignatureFieldNumber = 1; // Metadata: 0x00B0918B
	private string signature_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetPlayerSignatureReq> Parser { get => default; } // 0x0000000181AF47F0-0x0000000181AF4880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181AF44E0-0x0000000181AF4570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181AF4120-0x0000000181AF41A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181AF3BE0-0x0000000181AF3C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181AF4B60-0x0000000181AF4C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181AF49B0-0x0000000181AF4A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181AF4610-0x0000000181AF4700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181AF4B10-0x0000000181AF4B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181AF4240-0x0000000181AF4330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Signature { get => default; set {} } // 0x0000000181AF4570-0x0000000181AF4610 0x0000000181AF4430-0x0000000181AF44E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25571
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25572
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4015
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetPlayerSignatureReq() {} // 0x0000000181AF4E60-0x0000000181AF4ED0
	static SetPlayerSignatureReq() {} // 0x0000000181AF4DA0-0x0000000181AF4E60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetPlayerSignatureReq Clone() => default; // 0x0000000181AF4700-0x0000000181AF47F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetPlayerSignatureReq ShallowCopy() => default; // 0x0000000181AF41A0-0x0000000181AF4240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181AF3D60-0x0000000181AF3DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181AF4910-0x0000000181AF4960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181AF4960-0x0000000181AF49B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181AF3DB0-0x0000000181AF3E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181AF3F50-0x0000000181AF4020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetPlayerSignatureReq other) => default; // 0x0000000181AF3E20-0x0000000181AF3F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181AF4330-0x0000000181AF4430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181AF4C50-0x0000000181AF4DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181AF4A10-0x0000000181AF4B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181AF4020-0x0000000181AF4120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetPlayerSignatureReq other) {} // 0x0000000181AF3C40-0x0000000181AF3D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181AF3B00-0x0000000181AF3BE0
}

