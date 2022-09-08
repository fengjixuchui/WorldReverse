/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MailTextContent : MessageBase, IMessage<MailTextContent> // TypeDefIndex: 26076
{
	// Fields
	private static readonly MessageParser<MailTextContent> _parser; // 0x00
	public const int TitleFieldNumber = 1; // Metadata: 0x00B0B05F
	private string title_; // 0x18
	public const int ContentFieldNumber = 2; // Metadata: 0x00B0B063
	private string content_; // 0x20
	public const int SenderFieldNumber = 3; // Metadata: 0x00B0B067
	private string sender_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MailTextContent> Parser { get => default; } // 0x0000000180CAB130-0x0000000180CAB1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180CAAE10-0x0000000180CAAEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180CAA9B0-0x0000000180CAAA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180CAA100-0x0000000180CAA160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180CAB6A0-0x0000000180CAB790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180CAB390-0x0000000180CAB3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180CAAEA0-0x0000000180CAAF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180CAB650-0x0000000180CAB6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180CAAAD0-0x0000000180CAABC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Title { get => default; set {} } // 0x0000000180CAA160-0x0000000180CAA200 0x0000000180CAAD60-0x0000000180CAAE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Content { get => default; set {} } // 0x0000000180CAB250-0x0000000180CAB2F0 0x0000000180CAB080-0x0000000180CAB130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Sender { get => default; set {} } // 0x0000000180CAA200-0x0000000180CAA2A0 0x0000000180CAB3F0-0x0000000180CAB4A0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MailTextContent() {} // 0x0000000180CABA80-0x0000000180CABB10
	static MailTextContent() {} // 0x0000000180CAB9C0-0x0000000180CABA80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MailTextContent Clone() => default; // 0x0000000180CAAF90-0x0000000180CAB080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MailTextContent ShallowCopy() => default; // 0x0000000180CAAA30-0x0000000180CAAAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180CAA450-0x0000000180CAA4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180CAB2F0-0x0000000180CAB340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180CAB340-0x0000000180CAB390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180CAA4A0-0x0000000180CAA530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180CAA530-0x0000000180CAA600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MailTextContent other) => default; // 0x0000000180CAA600-0x0000000180CAA7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180CAABC0-0x0000000180CAAD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180CAB790-0x0000000180CAB9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180CAB4A0-0x0000000180CAB650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180CAA7E0-0x0000000180CAA9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MailTextContent other) {} // 0x0000000180CAA2A0-0x0000000180CAA450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180CA9FE0-0x0000000180CAA100
}

