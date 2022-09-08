/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientNewMailNotify : MessageBase, IMessage<ClientNewMailNotify> // TypeDefIndex: 23813
{
	// Fields
	private static readonly MessageParser<ClientNewMailNotify> _parser; // 0x00
	public const int NotReadNumFieldNumber = 1; // Metadata: 0x00B04E1F
	private uint notReadNum_; // 0x18
	public const int NotGotAttachmentNumFieldNumber = 2; // Metadata: 0x00B04E23
	private uint notGotAttachmentNum_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientNewMailNotify> Parser { get => default; } // 0x00000001821F4FA0-0x00000001821F5030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001821F4B50-0x00000001821F4BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001821F4840-0x00000001821F48C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001821F4230-0x00000001821F4290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001821F5330-0x00000001821F5420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001821F5160-0x00000001821F51C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001821F4C80-0x00000001821F4D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001821F52E0-0x00000001821F5330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001821F4960-0x00000001821F4A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NotReadNum { get => default; set {} } // 0x00000001821F47A0-0x00000001821F4840 0x00000001821F4BE0-0x00000001821F4C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NotGotAttachmentNum { get => default; set {} } // 0x00000001821F4F00-0x00000001821F4FA0 0x00000001821F4E60-0x00000001821F4F00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23814
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23815
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1410
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientNewMailNotify() {} // 0x00000001821F56E0-0x00000001821F5740
	static ClientNewMailNotify() {} // 0x00000001821F5620-0x00000001821F56E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientNewMailNotify Clone() => default; // 0x00000001821F4D70-0x00000001821F4E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientNewMailNotify ShallowCopy() => default; // 0x00000001821F48C0-0x00000001821F4960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001821F43C0-0x00000001821F4410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821F50C0-0x00000001821F5110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821F5110-0x00000001821F5160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001821F4410-0x00000001821F4480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001821F4480-0x00000001821F4550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientNewMailNotify other) => default; // 0x00000001821F4550-0x00000001821F4670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001821F4A50-0x00000001821F4B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001821F5420-0x00000001821F5620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001821F51C0-0x00000001821F52E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001821F4670-0x00000001821F47A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientNewMailNotify other) {} // 0x00000001821F4290-0x00000001821F43C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001821F4130-0x00000001821F4230
}

