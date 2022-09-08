/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EnterSceneDoneRsp : MessageBase, IMessage<EnterSceneDoneRsp> // TypeDefIndex: 25157
{
	// Fields
	private static readonly MessageParser<EnterSceneDoneRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B081B7
	private int retcode_; // 0x18
	public const int EnterSceneTokenFieldNumber = 2; // Metadata: 0x00B081BB
	private uint enterSceneToken_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnterSceneDoneRsp> Parser { get => default; } // 0x0000000182C649A0-0x0000000182C64A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C64690-0x0000000182C64720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C64380-0x0000000182C64400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C63CD0-0x0000000182C63D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C64DD0-0x0000000182C64EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C64C00-0x0000000182C64C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C647C0-0x0000000182C648B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C64D80-0x0000000182C64DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C644A0-0x0000000182C64590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182C642E0-0x0000000182C64380 0x0000000182C63F20-0x0000000182C63FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EnterSceneToken { get => default; set {} } // 0x0000000182C64720-0x0000000182C647C0 0x0000000182C64B60-0x0000000182C64C00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25158
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25159
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 286
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterSceneDoneRsp() {} // 0x0000000182C65180-0x0000000182C651E0
	static EnterSceneDoneRsp() {} // 0x0000000182C650C0-0x0000000182C65180

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterSceneDoneRsp Clone() => default; // 0x0000000182C648B0-0x0000000182C649A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterSceneDoneRsp ShallowCopy() => default; // 0x0000000182C64400-0x0000000182C644A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C63E60-0x0000000182C63EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C64AC0-0x0000000182C64B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C64B10-0x0000000182C64B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C63EB0-0x0000000182C63F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C640E0-0x0000000182C641B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EnterSceneDoneRsp other) => default; // 0x0000000182C63FC0-0x0000000182C640E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C64590-0x0000000182C64690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C64EC0-0x0000000182C650C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C64C60-0x0000000182C64D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C641B0-0x0000000182C642E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EnterSceneDoneRsp other) {} // 0x0000000182C63D30-0x0000000182C63E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C63BD0-0x0000000182C63CD0
}

