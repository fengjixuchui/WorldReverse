/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WidgetGadgetDataNotify : MessageBase, IMessage<WidgetGadgetDataNotify> // TypeDefIndex: 25894
{
	// Fields
	private static readonly MessageParser<WidgetGadgetDataNotify> _parser; // 0x00
	public const int WidgetGadgetDataFieldNumber = 1; // Metadata: 0x00B09CF3
	private WidgetGadgetData widgetGadgetData_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WidgetGadgetDataNotify> Parser { get => default; } // 0x000000018121C4C0-0x000000018121C550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018121C250-0x000000018121C2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018121BE50-0x000000018121BED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018121B7C0-0x000000018121B820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018121C910-0x000000018121CA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018121C780-0x000000018121C7E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018121C2E0-0x000000018121C3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018121C8C0-0x000000018121C910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018121BF70-0x000000018121C060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetGadgetData WidgetGadgetData { get => default; set {} } // 0x000000018121C6E0-0x000000018121C780 0x000000018121C1B0-0x000000018121C250

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25895
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25896
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4290
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetGadgetDataNotify() {} // 0x000000018121CC10-0x000000018121CC70
	static WidgetGadgetDataNotify() {} // 0x000000018121CB50-0x000000018121CC10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetGadgetDataNotify Clone() => default; // 0x000000018121C3D0-0x000000018121C4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetGadgetDataNotify ShallowCopy() => default; // 0x000000018121BED0-0x000000018121BF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018121B980-0x000000018121BA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018121C5E0-0x000000018121C660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018121C660-0x000000018121C6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018121BA00-0x000000018121BB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018121BB20-0x000000018121BBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WidgetGadgetDataNotify other) => default; // 0x000000018121BBF0-0x000000018121BD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018121C060-0x000000018121C1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018121CA00-0x000000018121CB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018121C7E0-0x000000018121C8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018121BD00-0x000000018121BE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WidgetGadgetDataNotify other) {} // 0x000000018121B820-0x000000018121B980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018121B6B0-0x000000018121B7C0
}

