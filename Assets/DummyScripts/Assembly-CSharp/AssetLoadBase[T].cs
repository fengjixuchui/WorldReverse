/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class AssetLoadBase<T> : AsyncJobProxy // TypeDefIndex: 19889
	where T : UnityEngine.Object
{
	// Fields
	protected T _asset;
	protected int _refCount;
	protected uint _handler;
	protected AsyncJob _job;
	protected ulong _path;
	protected ComplexUniHandlerAssetReceiver<T> _asyncLoadCallback;

	// Properties
	public T asset { get; }

	// Constructors
	public AssetLoadBase() {}

	// Methods
	public bool CheckRef() => default;
	public virtual void Refine(ulong path) {}
	public abstract bool CheckVoucher(object voucher);
	public virtual void Clear() {}
	public virtual void Preload() {}
	public void Recycle() {}
	protected abstract void BroadcastFinishCallback();
	private void AsyncLoadCallback(ulong hash, bool loadSucceeded, uint handle, T prefab) {}
	protected virtual void AddRefCount() {}
	public virtual void MinusRefCount() {}
	public override string ToString() => default;
	public abstract int CallBackCount();
	public abstract void Dismiss(object voucher);
	public virtual void AfterFinish() {}
	public virtual void BeforeFinish() {}
}

