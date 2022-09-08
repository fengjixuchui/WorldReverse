/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class MessageBase : IMessage // TypeDefIndex: 26328
{
	// Fields
	private const byte IS_IN_POOL_MASK = 1; // Metadata: 0x00B0BDE3
	private const byte IS_ALLOC_FROM_POOL_MASK = 2; // Metadata: 0x00B0BDE4
	private const byte IS_READ_ONLY_MASK = 4; // Metadata: 0x00B0BDE5
	public int count; // 0x10
	private byte _flag; // 0x14

	// Properties
	public abstract ushort CmdId { get; }
	public abstract MessageDescriptor Descriptor { get; }
	public abstract string ClassName { get; }
	public abstract string FullClassName { get; }
	public bool IsReadOnly { /* [XID] */ /* 0x0000000189A36440-0x0000000189A36460 */ get; } // 0x0000000182B7EAF0-0x0000000182B7EBA0 
	public bool IsAllocFromPool { /* [XID] */ /* 0x0000000189A3D9C0-0x0000000189A3D9E0 */ get; /* [XID] */ /* 0x0000000189A45160-0x0000000189A45180 */ set; } // 0x0000000182B7EF70-0x0000000182B7F020 0x0000000182B7EC50-0x0000000182B7ED10
	public bool IsInPool { /* [XID] */ /* 0x0000000189A35C80-0x0000000189A35CA0 */ get; /* [XID] */ /* 0x00000001896FF730-0x00000001896FF750 */ set; } // 0x0000000182B7F0F0-0x0000000182B7F1A0 0x0000000182B7F020-0x0000000182B7F0F0

	// Constructors
	protected MessageBase() {} // 0x0000000182B7F3C0-0x0000000182B7F420

	// Methods
	public abstract int CalculateSize();
	public abstract void MergeFrom(CodedInputStream input);
	public abstract void Reset();
	public abstract void WriteTo(CodedOutputStream output);
	~MessageBase() {} // 0x0000000182B7EE10-0x0000000182B7EF70
	// [XID] // 0x0000000189A5BAD0-0x0000000189A5BAF0
	public bool IsNoneReference() => default; // 0x0000000182B7EBA0-0x0000000182B7EC50
	// [XID] // 0x0000000189A631C0-0x0000000189A631E0
	public void AddReferenceMask(MessageReferenceMaskType mask = MessageReferenceMaskType.Invalid /* Metadata: 0x00B0BDDB */) {} // 0x0000000182B7ED10-0x0000000182B7EE10
	// [XID] // 0x0000000189A6AD20-0x0000000189A6AD40
	public void DeleteReferenceMask(MessageReferenceMaskType mask = MessageReferenceMaskType.Invalid /* Metadata: 0x00B0BDDF */) {} // 0x0000000182B7F1A0-0x0000000182B7F3C0
	protected abstract void InternalAddReferenceMask(MessageReferenceMaskType mask);
	protected abstract void InternalDeleteReferenceMask(MessageReferenceMaskType mask);
	protected abstract void InternalSetInPool(bool value);
}

