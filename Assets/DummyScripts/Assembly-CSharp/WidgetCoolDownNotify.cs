/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WidgetCoolDownNotify : MessageBase, IMessage<WidgetCoolDownNotify> // TypeDefIndex: 25841
{
	// Fields
	private static readonly MessageParser<WidgetCoolDownNotify> _parser; // 0x00
	public const int GroupCoolDownDataListFieldNumber = 1; // Metadata: 0x00B09B1B
	private static readonly FieldCodec<WidgetCoolDownData> _repeated_groupCoolDownDataList_codec; // 0x08
	private readonly RepeatedMessageField<WidgetCoolDownData> groupCoolDownDataList_; // 0x18
	public const int NormalCoolDownDataListFieldNumber = 2; // Metadata: 0x00B09B1F
	private static readonly FieldCodec<WidgetCoolDownData> _repeated_normalCoolDownDataList_codec; // 0x10
	private readonly RepeatedMessageField<WidgetCoolDownData> normalCoolDownDataList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WidgetCoolDownNotify> Parser { get => default; } // 0x00000001843B9E10-0x00000001843B9EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001843B9AE0-0x00000001843B9B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001843B97E0-0x00000001843B9860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001843B9190-0x00000001843B91F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001843BA250-0x00000001843BA340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001843BA070-0x00000001843BA0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001843B9C30-0x00000001843B9D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001843BA200-0x00000001843BA250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001843B9900-0x00000001843B99F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<WidgetCoolDownData> GroupCoolDownDataList { get => default; } // 0x00000001843B9B70-0x00000001843B9BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<WidgetCoolDownData> NormalCoolDownDataList { get => default; } // 0x00000001843B9BD0-0x00000001843B9C30 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25842
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25843
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4262
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetCoolDownNotify() {} // 0x00000001843BA640-0x00000001843BA6F0
	static WidgetCoolDownNotify() {} // 0x00000001843BA500-0x00000001843BA640

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetCoolDownNotify Clone() => default; // 0x00000001843B9D20-0x00000001843B9E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetCoolDownNotify ShallowCopy() => default; // 0x00000001843B9860-0x00000001843B9900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001843B9350-0x00000001843B93A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843B9F30-0x00000001843B9FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843B9FD0-0x00000001843BA070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001843B93A0-0x00000001843B94C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001843B94C0-0x00000001843B9590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WidgetCoolDownNotify other) => default; // 0x00000001843B9590-0x00000001843B96C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001843B99F0-0x00000001843B9AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001843BA340-0x00000001843BA500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001843BA0D0-0x00000001843BA200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001843B96C0-0x00000001843B97E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WidgetCoolDownNotify other) {} // 0x00000001843B91F0-0x00000001843B9350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001843B8FF0-0x00000001843B9190
}

