/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OpenBlossomCircleCampGuideNotify : MessageBase, IMessage<OpenBlossomCircleCampGuideNotify> // TypeDefIndex: 22612
{
	// Fields
	private static readonly MessageParser<OpenBlossomCircleCampGuideNotify> _parser; // 0x00
	public const int RefreshIdFieldNumber = 1; // Metadata: 0x00B01FDF
	private uint refreshId_; // 0x18
	public const int CircleCampIdListFieldNumber = 2; // Metadata: 0x00B01FE3
	private static readonly FieldCodec<uint> _repeated_circleCampIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> circleCampIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OpenBlossomCircleCampGuideNotify> Parser { get => default; } // 0x0000000183CD3320-0x0000000183CD33B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183CD3010-0x0000000183CD30A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183CD2D00-0x0000000183CD2D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183CD2680-0x0000000183CD26E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183CD3730-0x0000000183CD3820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183CD3540-0x0000000183CD35A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183CD30A0-0x0000000183CD3190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183CD36E0-0x0000000183CD3730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183CD2E20-0x0000000183CD2F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RefreshId { get => default; set {} } // 0x0000000183CD26E0-0x0000000183CD2780 0x0000000183CD3280-0x0000000183CD3320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> CircleCampIdList { get => default; } // 0x0000000183CD34E0-0x0000000183CD3540 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22613
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22614
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2707
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpenBlossomCircleCampGuideNotify() {} // 0x0000000183CD3AE0-0x0000000183CD3B70
	static OpenBlossomCircleCampGuideNotify() {} // 0x0000000183CD3A00-0x0000000183CD3AE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpenBlossomCircleCampGuideNotify Clone() => default; // 0x0000000183CD3190-0x0000000183CD3280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpenBlossomCircleCampGuideNotify ShallowCopy() => default; // 0x0000000183CD2D80-0x0000000183CD2E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183CD28B0-0x0000000183CD2900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CD3440-0x0000000183CD3490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CD3490-0x0000000183CD34E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183CD2900-0x0000000183CD29C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183CD29C0-0x0000000183CD2A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(OpenBlossomCircleCampGuideNotify other) => default; // 0x0000000183CD2A90-0x0000000183CD2BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183CD2F10-0x0000000183CD3010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183CD3820-0x0000000183CD3A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183CD35A0-0x0000000183CD36E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183CD2BC0-0x0000000183CD2D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(OpenBlossomCircleCampGuideNotify other) {} // 0x0000000183CD2780-0x0000000183CD28B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183CD2510-0x0000000183CD2680
}

