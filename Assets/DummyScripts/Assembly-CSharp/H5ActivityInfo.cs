/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class H5ActivityInfo : MessageBase, IMessage<H5ActivityInfo> // TypeDefIndex: 23296
{
	// Fields
	private static readonly MessageParser<H5ActivityInfo> _parser; // 0x00
	public const int H5ScheduleIdFieldNumber = 1; // Metadata: 0x00B03B47
	private uint h5ScheduleId_; // 0x18
	public const int H5ActivityIdFieldNumber = 2; // Metadata: 0x00B03B4B
	private uint h5ActivityId_; // 0x1C
	public const int BeginTimeFieldNumber = 3; // Metadata: 0x00B03B4F
	private uint beginTime_; // 0x20
	public const int EndTimeFieldNumber = 4; // Metadata: 0x00B03B53
	private uint endTime_; // 0x24
	public const int ContentCloseTimeFieldNumber = 5; // Metadata: 0x00B03B57
	private uint contentCloseTime_; // 0x28
	public const int PrefabPathFieldNumber = 6; // Metadata: 0x00B03B5B
	private string prefabPath_; // 0x30
	public const int UrlFieldNumber = 7; // Metadata: 0x00B03B5F
	private string url_; // 0x38
	public const int IsEntranceOpenFieldNumber = 8; // Metadata: 0x00B03B63
	private bool isEntranceOpen_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<H5ActivityInfo> Parser { get => default; } // 0x000000018502EBF0-0x000000018502EC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018502E6F0-0x000000018502E780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018502E1E0-0x000000018502E260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018502D620-0x000000018502D680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018502F630-0x000000018502F720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018502F0D0-0x000000018502F130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018502E8C0-0x000000018502E9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018502F540-0x000000018502F590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018502E300-0x000000018502E3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint H5ScheduleId { get => default; set {} } // 0x000000018502F130-0x000000018502F1D0 0x000000018502E820-0x000000018502E8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint H5ActivityId { get => default; set {} } // 0x000000018502E780-0x000000018502E820 0x000000018502ED10-0x000000018502EDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x000000018502F4A0-0x000000018502F540 0x000000018502EF90-0x000000018502F030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x000000018502EAA0-0x000000018502EB40 0x000000018502F030-0x000000018502F0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ContentCloseTime { get => default; set {} } // 0x000000018502F590-0x000000018502F630 0x000000018502E140-0x000000018502E1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PrefabPath { get => default; set {} } // 0x000000018502EE00-0x000000018502EEA0 0x000000018502EB40-0x000000018502EBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Url { get => default; set {} } // 0x000000018502EEF0-0x000000018502EF90 0x000000018502D9C0-0x000000018502DA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsEntranceOpen { get => default; set {} } // 0x000000018502E650-0x000000018502E6F0 0x000000018502D680-0x000000018502D720

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public H5ActivityInfo() {} // 0x000000018502FCF0-0x000000018502FD70
	static H5ActivityInfo() {} // 0x000000018502FC30-0x000000018502FCF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public H5ActivityInfo Clone() => default; // 0x000000018502E9B0-0x000000018502EAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public H5ActivityInfo ShallowCopy() => default; // 0x000000018502E260-0x000000018502E300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018502D970-0x000000018502D9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018502EDB0-0x000000018502EE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018502EEA0-0x000000018502EEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018502DA70-0x000000018502DB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018502DD80-0x000000018502DE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(H5ActivityInfo other) => default; // 0x000000018502DB40-0x000000018502DD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018502E3F0-0x000000018502E650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018502F720-0x000000018502FC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018502F1D0-0x000000018502F4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018502DE50-0x000000018502E140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(H5ActivityInfo other) {} // 0x000000018502D720-0x000000018502D970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018502D470-0x000000018502D620
}

