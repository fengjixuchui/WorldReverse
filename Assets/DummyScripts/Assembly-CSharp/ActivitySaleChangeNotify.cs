/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivitySaleChangeNotify : MessageBase, IMessage<ActivitySaleChangeNotify> // TypeDefIndex: 22059
{
	// Fields
	private static readonly MessageParser<ActivitySaleChangeNotify> _parser; // 0x00
	public const int SaleIdFieldNumber = 1; // Metadata: 0x00B00AFF
	private uint saleId_; // 0x18
	public const int IsCloseFieldNumber = 2; // Metadata: 0x00B00B03
	private bool isClose_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivitySaleChangeNotify> Parser { get => default; } // 0x0000000181A81640-0x0000000181A816D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A81290-0x0000000181A81320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A80F70-0x0000000181A80FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A808F0-0x0000000181A80950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A819D0-0x0000000181A81AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A81800-0x0000000181A81860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A81460-0x0000000181A81550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A81980-0x0000000181A819D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A81090-0x0000000181A81180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SaleId { get => default; set {} } // 0x0000000181A81320-0x0000000181A813C0 0x0000000181A813C0-0x0000000181A81460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsClose { get => default; set {} } // 0x0000000181A80BE0-0x0000000181A80C80 0x0000000181A80AD0-0x0000000181A80B70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22060
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22061
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2085
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivitySaleChangeNotify() {} // 0x0000000181A81D80-0x0000000181A81DE0
	static ActivitySaleChangeNotify() {} // 0x0000000181A81CC0-0x0000000181A81D80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivitySaleChangeNotify Clone() => default; // 0x0000000181A81550-0x0000000181A81640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivitySaleChangeNotify ShallowCopy() => default; // 0x0000000181A80FF0-0x0000000181A81090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A80A80-0x0000000181A80AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A81760-0x0000000181A817B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A817B0-0x0000000181A81800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A80B70-0x0000000181A80BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A80DA0-0x0000000181A80E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivitySaleChangeNotify other) => default; // 0x0000000181A80C80-0x0000000181A80DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A81180-0x0000000181A81290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A81AC0-0x0000000181A81CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A81860-0x0000000181A81980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A80E70-0x0000000181A80F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivitySaleChangeNotify other) {} // 0x0000000181A80950-0x0000000181A80A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A807F0-0x0000000181A808F0
}

