/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MultistagePlayStageEndNotify : MessageBase, IMessage<MultistagePlayStageEndNotify> // TypeDefIndex: 24157
{
	// Fields
	private static readonly MessageParser<MultistagePlayStageEndNotify> _parser; // 0x00
	public const int PlayIndexFieldNumber = 1; // Metadata: 0x00B05BB3
	private uint playIndex_; // 0x18
	public const int GroupIdFieldNumber = 2; // Metadata: 0x00B05BB7
	private uint groupId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MultistagePlayStageEndNotify> Parser { get => default; } // 0x000000018356D300-0x000000018356D390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018356CF50-0x000000018356CFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018356CC40-0x000000018356CCC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018356C590-0x000000018356C5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018356D690-0x000000018356D780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018356D4C0-0x000000018356D520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018356D080-0x000000018356D170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018356D640-0x000000018356D690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018356CD60-0x000000018356CE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayIndex { get => default; set {} } // 0x000000018356CB00-0x000000018356CBA0 0x000000018356CFE0-0x000000018356D080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x000000018356D170-0x000000018356D210 0x000000018356CBA0-0x000000018356CC40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24158
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24159
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5399
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayStageEndNotify() {} // 0x000000018356DA40-0x000000018356DAA0
	static MultistagePlayStageEndNotify() {} // 0x000000018356D980-0x000000018356DA40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayStageEndNotify Clone() => default; // 0x000000018356D210-0x000000018356D300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayStageEndNotify ShallowCopy() => default; // 0x000000018356CCC0-0x000000018356CD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018356C720-0x000000018356C770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018356D420-0x000000018356D470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018356D470-0x000000018356D4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018356C770-0x000000018356C7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018356C900-0x000000018356C9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MultistagePlayStageEndNotify other) => default; // 0x000000018356C7E0-0x000000018356C900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018356CE50-0x000000018356CF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018356D780-0x000000018356D980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018356D520-0x000000018356D640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018356C9D0-0x000000018356CB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MultistagePlayStageEndNotify other) {} // 0x000000018356C5F0-0x000000018356C720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018356C490-0x000000018356C590
}

