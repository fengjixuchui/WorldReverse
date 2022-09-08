/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GivingRecordChangeNotify : MessageBase, IMessage<GivingRecordChangeNotify> // TypeDefIndex: 24471
{
	// Fields
	private static readonly MessageParser<GivingRecordChangeNotify> _parser; // 0x00
	public const int GivingRecordFieldNumber = 1; // Metadata: 0x00B06817
	private GivingRecord givingRecord_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GivingRecordChangeNotify> Parser { get => default; } // 0x0000000184EC6CE0-0x0000000184EC6D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184EC6A70-0x0000000184EC6B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184EC6670-0x0000000184EC66F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184EC5F40-0x0000000184EC5FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184EC7090-0x0000000184EC7180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184EC6F00-0x0000000184EC6F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184EC6B00-0x0000000184EC6BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184EC7040-0x0000000184EC7090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184EC6830-0x0000000184EC6920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GivingRecord GivingRecord { get => default; set {} } // 0x0000000184EC6790-0x0000000184EC6830 0x0000000184EC6480-0x0000000184EC6520

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24472
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24473
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 156
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GivingRecordChangeNotify() {} // 0x0000000184EC7390-0x0000000184EC73F0
	static GivingRecordChangeNotify() {} // 0x0000000184EC72D0-0x0000000184EC7390

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GivingRecordChangeNotify Clone() => default; // 0x0000000184EC6BF0-0x0000000184EC6CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GivingRecordChangeNotify ShallowCopy() => default; // 0x0000000184EC66F0-0x0000000184EC6790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184EC6100-0x0000000184EC6180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184EC6E00-0x0000000184EC6E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184EC6E80-0x0000000184EC6F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184EC6180-0x0000000184EC62A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184EC63B0-0x0000000184EC6480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GivingRecordChangeNotify other) => default; // 0x0000000184EC62A0-0x0000000184EC63B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184EC6920-0x0000000184EC6A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184EC7180-0x0000000184EC72D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184EC6F60-0x0000000184EC7040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184EC6520-0x0000000184EC6670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GivingRecordChangeNotify other) {} // 0x0000000184EC5FA0-0x0000000184EC6100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184EC5E30-0x0000000184EC5F40
}

