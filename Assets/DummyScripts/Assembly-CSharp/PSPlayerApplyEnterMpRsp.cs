/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PSPlayerApplyEnterMpRsp : MessageBase, IMessage<PSPlayerApplyEnterMpRsp> // TypeDefIndex: 24063
{
	// Fields
	private static readonly MessageParser<PSPlayerApplyEnterMpRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0578F
	private int retcode_; // 0x18
	public const int TargetPsnIdFieldNumber = 2; // Metadata: 0x00B05793
	private string targetPsnId_; // 0x20
	public const int ParamFieldNumber = 3; // Metadata: 0x00B05797
	private uint param_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PSPlayerApplyEnterMpRsp> Parser { get => default; } // 0x0000000183312840-0x00000001833128D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183312530-0x00000001833125C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001833121C0-0x0000000183312240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001833119E0-0x0000000183311A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183312D70-0x0000000183312E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183312A00-0x0000000183312A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183312660-0x0000000183312750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183312D20-0x0000000183312D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001833122E0-0x00000001833123D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183312120-0x00000001833121C0 0x0000000183311CA0-0x0000000183311D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string TargetPsnId { get => default; set {} } // 0x00000001833125C0-0x0000000183312660 0x0000000183312E60-0x0000000183312F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Param { get => default; set {} } // 0x0000000183312A60-0x0000000183312B00 0x0000000183312B00-0x0000000183312BA0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24064
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24065
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1814
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PSPlayerApplyEnterMpRsp() {} // 0x0000000183313240-0x00000001833132B0
	static PSPlayerApplyEnterMpRsp() {} // 0x0000000183313180-0x0000000183313240

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PSPlayerApplyEnterMpRsp Clone() => default; // 0x0000000183312750-0x0000000183312840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PSPlayerApplyEnterMpRsp ShallowCopy() => default; // 0x0000000183312240-0x00000001833122E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183311BC0-0x0000000183311C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183312960-0x00000001833129B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833129B0-0x0000000183312A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183311C10-0x0000000183311CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183311D40-0x0000000183311E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PSPlayerApplyEnterMpRsp other) => default; // 0x0000000183311E10-0x0000000183311F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833123D0-0x0000000183312530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183312F10-0x0000000183313180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183312BA0-0x0000000183312D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183311F80-0x0000000183312120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PSPlayerApplyEnterMpRsp other) {} // 0x0000000183311A40-0x0000000183311BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001833118D0-0x00000001833119E0
}

