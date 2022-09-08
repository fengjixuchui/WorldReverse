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

public abstract class AssetLoadBase2<T> : AssetLoadBase<T> // TypeDefIndex: 19890
	where T : UnityEngine.Object
{
	// Fields
	protected DoublyList<Action> _callbacks;

	// Constructors
	public AssetLoadBase2() {}

	// Methods
	public override bool CheckVoucher(object voucher) => default;
	public override void Clear() {}
	protected override void BroadcastFinishCallback() {}
	public override int CallBackCount() => default;
	public virtual AsyncJob DoPreloadAsyncWithJob(Action onLoadFinish) => default;
	public override void Dismiss(object voucher) {}
}

