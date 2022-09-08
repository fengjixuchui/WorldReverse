/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuickUseWidgetReq : MessageBase, IMessage<QuickUseWidgetReq> // TypeDefIndex: 25834
{
	// Fields
	private static readonly MessageParser<QuickUseWidgetReq> _parser; // 0x00
	public const int IsPosValidFieldNumber = 1; // Metadata: 0x00B09AD7
	private bool isPosValid_; // 0x18
	public const int PosFieldNumber = 2; // Metadata: 0x00B09ADB
	private Vector pos_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuickUseWidgetReq> Parser { get => default; } // 0x0000000183B49EA0-0x0000000183B49F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183B49C30-0x0000000183B49CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183B498A0-0x0000000183B49920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183B49100-0x0000000183B49160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183B4A3D0-0x0000000183B4A4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183B4A160-0x0000000183B4A1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183B49CC0-0x0000000183B49DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183B4A380-0x0000000183B4A3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183B499C0-0x0000000183B49AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsPosValid { get => default; set {} } // 0x0000000183B49160-0x0000000183B49200 0x0000000183B4A4C0-0x0000000183B4A560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000183B4A0C0-0x0000000183B4A160 0x0000000183B4A2E0-0x0000000183B4A380

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25835
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25836
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4260
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuickUseWidgetReq() {} // 0x0000000183B4A800-0x0000000183B4A860
	static QuickUseWidgetReq() {} // 0x0000000183B4A740-0x0000000183B4A800

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuickUseWidgetReq Clone() => default; // 0x0000000183B49DB0-0x0000000183B49EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuickUseWidgetReq ShallowCopy() => default; // 0x0000000183B49920-0x0000000183B499C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183B49380-0x0000000183B49400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B49FC0-0x0000000183B4A040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B4A040-0x0000000183B4A0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183B49400-0x0000000183B49530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183B49660-0x0000000183B49730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuickUseWidgetReq other) => default; // 0x0000000183B49530-0x0000000183B49660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183B49AB0-0x0000000183B49C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183B4A560-0x0000000183B4A740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183B4A1C0-0x0000000183B4A2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183B49730-0x0000000183B498A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuickUseWidgetReq other) {} // 0x0000000183B49200-0x0000000183B49380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183B48FC0-0x0000000183B49100
}

