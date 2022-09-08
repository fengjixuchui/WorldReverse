/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DraftTwiceConfirmResultNotify : MessageBase, IMessage<DraftTwiceConfirmResultNotify> // TypeDefIndex: 22794
{
	// Fields
	private static readonly MessageParser<DraftTwiceConfirmResultNotify> _parser; // 0x00
	public const int DraftIdFieldNumber = 1; // Metadata: 0x00B0261F
	private uint draftId_; // 0x18
	public const int IsAllArgeeFieldNumber = 2; // Metadata: 0x00B02623
	private bool isAllArgee_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DraftTwiceConfirmResultNotify> Parser { get => default; } // 0x00000001815C99F0-0x00000001815C9A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001815C9780-0x00000001815C9810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001815C9460-0x00000001815C94E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001815C8DE0-0x00000001815C8E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001815C9EC0-0x00000001815C9FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001815C9CF0-0x00000001815C9D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001815C9810-0x00000001815C9900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001815C9E70-0x00000001815C9EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001815C9580-0x00000001815C9670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DraftId { get => default; set {} } // 0x00000001815C9030-0x00000001815C90D0 0x00000001815C9B60-0x00000001815C9C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAllArgee { get => default; set {} } // 0x00000001815C93C0-0x00000001815C9460 0x00000001815C9C50-0x00000001815C9CF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22795
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22796
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5413
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftTwiceConfirmResultNotify() {} // 0x00000001815CA270-0x00000001815CA2D0
	static DraftTwiceConfirmResultNotify() {} // 0x00000001815CA1B0-0x00000001815CA270

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftTwiceConfirmResultNotify Clone() => default; // 0x00000001815C9900-0x00000001815C99F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftTwiceConfirmResultNotify ShallowCopy() => default; // 0x00000001815C94E0-0x00000001815C9580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001815C8F70-0x00000001815C8FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815C9B10-0x00000001815C9B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815C9C00-0x00000001815C9C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001815C8FC0-0x00000001815C9030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001815C90D0-0x00000001815C91A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DraftTwiceConfirmResultNotify other) => default; // 0x00000001815C91A0-0x00000001815C92C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001815C9670-0x00000001815C9780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001815C9FB0-0x00000001815CA1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001815C9D50-0x00000001815C9E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001815C92C0-0x00000001815C93C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DraftTwiceConfirmResultNotify other) {} // 0x00000001815C8E40-0x00000001815C8F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001815C8CE0-0x00000001815C8DE0
}

