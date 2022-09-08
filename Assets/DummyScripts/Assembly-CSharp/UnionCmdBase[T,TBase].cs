/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class UnionCmdBase<T, TBase> : MessageBase, IDeepCloneable<T> // TypeDefIndex: 21711
	where T : UnionCmdBase<T, TBase>, new()
	where TBase : MessageBase, new()
{
	// Fields
	protected TBase _internalMessage;
	public int messageSize;

	// Properties
	public TBase Message { get; }
	public override string ClassName { get; }
	public override string FullClassName { get; }
	public override ushort CmdId { get; }
	public override MessageDescriptor Descriptor { get; }

	// Constructors
	protected UnionCmdBase() {}

	// Methods
	public static MessageBase Create(MessageBase sourceMessage, CodedInputStream inputHelper) => default;
	public override int CalculateSize() => default;
	public override void MergeFrom(CodedInputStream input) {}
	public override void Reset() {}
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {}
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {}
	public override void WriteTo(CodedOutputStream output) {}
	public MessageBase AfterDeserializeInWorkThread(MessageBase message, CodedInputStream inputHelper) => default;
	protected abstract void internalReset();
	protected abstract void internalAfterDeserializeInWorkThread(CodedInputStream inputHelper);
	protected abstract void InternalMergeFrom(T other);
	protected abstract void internalDeleteReferenceMask();
	protected abstract void internalAddReferenceMask();
	protected override void InternalSetInPool(bool value) {}
	public bool Equals(T other) => default;
	public T Clone() => default;
	protected static void CloneRepeatedMessage<M>(RepeatedMessageField<M> from, RepeatedMessageField<M> to)
		where M : MessageBase, IDeepCloneable<M> {}
	protected void RecycleRepeatMessage<M>(RepeatedMessageField<M> message)
		where M : MessageBase, IDeepCloneable<M> {}
}

