/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ShowTemplateReminderNotify : MessageBase, IMessage<ShowTemplateReminderNotify> // TypeDefIndex: 25293
{
	// Fields
	private static readonly MessageParser<ShowTemplateReminderNotify> _parser; // 0x00
	public const int TemplateReminderIdFieldNumber = 1; // Metadata: 0x00B0864B
	private uint templateReminderId_; // 0x18
	public const int ParamListFieldNumber = 2; // Metadata: 0x00B0864F
	private static readonly FieldCodec<int> _repeated_paramList_codec; // 0x08
	private readonly RepeatedPrimitiveField<int> paramList_; // 0x20
	public const int ParamUidListFieldNumber = 3; // Metadata: 0x00B08653
	private static readonly FieldCodec<uint> _repeated_paramUidList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> paramUidList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ShowTemplateReminderNotify> Parser { get => default; } // 0x00000001823715F0-0x0000000182371680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823712E0-0x0000000182371370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182370F10-0x0000000182370F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182370840-0x00000001823708A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182371A30-0x0000000182371B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001823717B0-0x0000000182371810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182371370-0x0000000182371460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001823719E0-0x0000000182371A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182371030-0x0000000182371120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TemplateReminderId { get => default; set {} } // 0x0000000182371240-0x00000001823712E0 0x0000000182371550-0x00000001823715F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<int> ParamList { get => default; } // 0x0000000182371810-0x0000000182371870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ParamUidList { get => default; } // 0x0000000182371B20-0x0000000182371B80 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25294
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25295
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3046
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowTemplateReminderNotify() {} // 0x0000000182371EE0-0x0000000182371F90
	static ShowTemplateReminderNotify() {} // 0x0000000182371DE0-0x0000000182371EE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowTemplateReminderNotify Clone() => default; // 0x0000000182371460-0x0000000182371550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowTemplateReminderNotify ShallowCopy() => default; // 0x0000000182370F90-0x0000000182371030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823709F0-0x0000000182370A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182371710-0x0000000182371760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182371760-0x00000001823717B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182370A40-0x0000000182370B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182370CC0-0x0000000182370D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ShowTemplateReminderNotify other) => default; // 0x0000000182370B70-0x0000000182370CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182371120-0x0000000182371240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182371B80-0x0000000182371DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182371870-0x00000001823719E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182370D90-0x0000000182370F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ShowTemplateReminderNotify other) {} // 0x00000001823708A0-0x00000001823709F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182370660-0x0000000182370840
}

