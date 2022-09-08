/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuickUseWidgetRsp : MessageBase, IMessage<QuickUseWidgetRsp> // TypeDefIndex: 25837
{
	// Fields
	private static readonly MessageParser<QuickUseWidgetRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09AF3
	private int retcode_; // 0x18
	public const int MaterialIdFieldNumber = 2; // Metadata: 0x00B09AF7
	private uint materialId_; // 0x1C
	public const int DetectorDataFieldNumber = 3; // Metadata: 0x00B09AFB
	private OneoffGatherPointDetectorData detectorData_; // 0x20
	public const int ClientCollectorDataFieldNumber = 4; // Metadata: 0x00B09AFF
	private ClientCollectorData clientCollectorData_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuickUseWidgetRsp> Parser { get => default; } // 0x0000000181EC4CF0-0x0000000181EC4D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181EC48A0-0x0000000181EC4930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181EC4440-0x0000000181EC44C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181EC37D0-0x0000000181EC3830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181EC5210-0x0000000181EC5300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181EC4FD0-0x0000000181EC5030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181EC4B10-0x0000000181EC4C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181EC51C0-0x0000000181EC5210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181EC4560-0x0000000181EC4650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181EC43A0-0x0000000181EC4440 0x0000000181EC3D80-0x0000000181EC3E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaterialId { get => default; set {} } // 0x0000000181EC49D0-0x0000000181EC4A70 0x0000000181EC4A70-0x0000000181EC4B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OneoffGatherPointDetectorData DetectorData { get => default; set {} } // 0x0000000181EC4F30-0x0000000181EC4FD0 0x0000000181EC4300-0x0000000181EC43A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientCollectorData ClientCollectorData { get => default; set {} } // 0x0000000181EC4930-0x0000000181EC49D0 0x0000000181EC3A50-0x0000000181EC3AF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25838
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25839
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4261
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuickUseWidgetRsp() {} // 0x0000000181EC56A0-0x0000000181EC5700
	static QuickUseWidgetRsp() {} // 0x0000000181EC55E0-0x0000000181EC56A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuickUseWidgetRsp Clone() => default; // 0x0000000181EC4C00-0x0000000181EC4CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuickUseWidgetRsp ShallowCopy() => default; // 0x0000000181EC44C0-0x0000000181EC4560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181EC3AF0-0x0000000181EC3B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EC4E10-0x0000000181EC4EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EC4EA0-0x0000000181EC4F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181EC3B80-0x0000000181EC3D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181EC3FA0-0x0000000181EC4070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuickUseWidgetRsp other) => default; // 0x0000000181EC3E20-0x0000000181EC3FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181EC4650-0x0000000181EC48A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181EC5300-0x0000000181EC55E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181EC5030-0x0000000181EC51C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181EC4070-0x0000000181EC4300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuickUseWidgetRsp other) {} // 0x0000000181EC3830-0x0000000181EC3A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181EC3620-0x0000000181EC37D0
}

