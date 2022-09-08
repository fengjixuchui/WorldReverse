/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WidgetReportReq : MessageBase, IMessage<WidgetReportReq> // TypeDefIndex: 25844
{
	// Fields
	private static readonly MessageParser<WidgetReportReq> _parser; // 0x00
	public const int MaterialIdFieldNumber = 1; // Metadata: 0x00B09B33
	private uint materialId_; // 0x18
	public const int IsClearHintFieldNumber = 2; // Metadata: 0x00B09B37
	private bool isClearHint_; // 0x1C
	public const int IsClientCollectFieldNumber = 3; // Metadata: 0x00B09B3B
	private bool isClientCollect_; // 0x1D

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WidgetReportReq> Parser { get => default; } // 0x00000001842475C0-0x0000000184247650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184247170-0x0000000184247200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184246E20-0x0000000184246EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001842467D0-0x0000000184246830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184247A30-0x0000000184247B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184247780-0x00000001842477E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184247340-0x0000000184247430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001842479E0-0x0000000184247A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184246F40-0x0000000184247030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaterialId { get => default; set {} } // 0x0000000184247200-0x00000001842472A0 0x00000001842472A0-0x0000000184247340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsClearHint { get => default; set {} } // 0x00000001842477E0-0x0000000184247880 0x0000000184247520-0x00000001842475C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsClientCollect { get => default; set {} } // 0x0000000184247B20-0x0000000184247BC0 0x0000000184246990-0x0000000184246A30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25845
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25846
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4263
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetReportReq() {} // 0x0000000184247F10-0x0000000184247F70
	static WidgetReportReq() {} // 0x0000000184247E50-0x0000000184247F10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetReportReq Clone() => default; // 0x0000000184247430-0x0000000184247520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetReportReq ShallowCopy() => default; // 0x0000000184246EA0-0x0000000184246F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184246A30-0x0000000184246A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842476E0-0x0000000184247730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184247730-0x0000000184247780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184246A80-0x0000000184246B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184246B00-0x0000000184246BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WidgetReportReq other) => default; // 0x0000000184246BD0-0x0000000184246D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184247030-0x0000000184247170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184247BC0-0x0000000184247E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184247880-0x00000001842479E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184246D10-0x0000000184246E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WidgetReportReq other) {} // 0x0000000184246830-0x0000000184246990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001842466C0-0x00000001842467D0
}

