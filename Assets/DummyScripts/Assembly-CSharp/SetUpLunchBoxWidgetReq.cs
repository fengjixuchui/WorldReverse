/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetUpLunchBoxWidgetReq : MessageBase, IMessage<SetUpLunchBoxWidgetReq> // TypeDefIndex: 25825
{
	// Fields
	private static readonly MessageParser<SetUpLunchBoxWidgetReq> _parser; // 0x00
	public const int LunchBoxDataFieldNumber = 1; // Metadata: 0x00B09A6B
	private LunchBoxData lunchBoxData_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetUpLunchBoxWidgetReq> Parser { get => default; } // 0x00000001833C0CE0-0x00000001833C0D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001833C09D0-0x00000001833C0A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001833C0670-0x00000001833C06F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001833BFFE0-0x00000001833C0040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001833C1130-0x00000001833C1220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001833C0FA0-0x00000001833C1000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001833C0B00-0x00000001833C0BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001833C10E0-0x00000001833C1130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001833C0790-0x00000001833C0880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LunchBoxData LunchBoxData { get => default; set {} } // 0x00000001833C0E80-0x00000001833C0F20 0x00000001833C0A60-0x00000001833C0B00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25826
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25827
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4258
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetUpLunchBoxWidgetReq() {} // 0x00000001833C1430-0x00000001833C1490
	static SetUpLunchBoxWidgetReq() {} // 0x00000001833C1370-0x00000001833C1430

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetUpLunchBoxWidgetReq Clone() => default; // 0x00000001833C0BF0-0x00000001833C0CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetUpLunchBoxWidgetReq ShallowCopy() => default; // 0x00000001833C06F0-0x00000001833C0790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001833C01A0-0x00000001833C0220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833C0E00-0x00000001833C0E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833C0F20-0x00000001833C0FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001833C0220-0x00000001833C0340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833C0340-0x00000001833C0410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetUpLunchBoxWidgetReq other) => default; // 0x00000001833C0410-0x00000001833C0520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833C0880-0x00000001833C09D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001833C1220-0x00000001833C1370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001833C1000-0x00000001833C10E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001833C0520-0x00000001833C0670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetUpLunchBoxWidgetReq other) {} // 0x00000001833C0040-0x00000001833C01A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001833BFED0-0x00000001833BFFE0
}

