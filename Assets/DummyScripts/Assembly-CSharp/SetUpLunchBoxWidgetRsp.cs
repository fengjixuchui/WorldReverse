/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetUpLunchBoxWidgetRsp : MessageBase, IMessage<SetUpLunchBoxWidgetRsp> // TypeDefIndex: 25828
{
	// Fields
	private static readonly MessageParser<SetUpLunchBoxWidgetRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09A83
	private int retcode_; // 0x18
	public const int LunchBoxDataFieldNumber = 2; // Metadata: 0x00B09A87
	private LunchBoxData lunchBoxData_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetUpLunchBoxWidgetRsp> Parser { get => default; } // 0x0000000182B2D560-0x0000000182B2D5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182B2D250-0x0000000182B2D2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182B2CEC0-0x0000000182B2CF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182B2C650-0x0000000182B2C6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182B2D9F0-0x0000000182B2DAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182B2D820-0x0000000182B2D880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182B2D380-0x0000000182B2D470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182B2D9A0-0x0000000182B2D9F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182B2CFE0-0x0000000182B2D0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182B2CE20-0x0000000182B2CEC0 0x0000000182B2C9E0-0x0000000182B2CA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LunchBoxData LunchBoxData { get => default; set {} } // 0x0000000182B2D700-0x0000000182B2D7A0 0x0000000182B2D2E0-0x0000000182B2D380

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25829
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25830
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4259
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetUpLunchBoxWidgetRsp() {} // 0x0000000182B2DD80-0x0000000182B2DDE0
	static SetUpLunchBoxWidgetRsp() {} // 0x0000000182B2DCC0-0x0000000182B2DD80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetUpLunchBoxWidgetRsp Clone() => default; // 0x0000000182B2D470-0x0000000182B2D560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetUpLunchBoxWidgetRsp ShallowCopy() => default; // 0x0000000182B2CF40-0x0000000182B2CFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182B2C830-0x0000000182B2C8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B2D680-0x0000000182B2D700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B2D7A0-0x0000000182B2D820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182B2C8B0-0x0000000182B2C9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182B2CBB0-0x0000000182B2CC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetUpLunchBoxWidgetRsp other) => default; // 0x0000000182B2CA80-0x0000000182B2CBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182B2D0D0-0x0000000182B2D250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182B2DAE0-0x0000000182B2DCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182B2D880-0x0000000182B2D9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182B2CC80-0x0000000182B2CE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetUpLunchBoxWidgetRsp other) {} // 0x0000000182B2C6B0-0x0000000182B2C830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182B2C510-0x0000000182B2C650
}

