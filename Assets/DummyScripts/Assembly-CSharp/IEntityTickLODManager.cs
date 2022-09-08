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

public interface IEntityTickLODManager // TypeDefIndex: 21297
{
	// Methods
	T AllocateTickBalanceProxy<T, TSpawner>()
		where T : BalanceTickObjectProxy
		where TSpawner : class, ISpawner<T>, new();
	void RegisterTickBalanceProxy(BalanceTickObjectProxy proxy);
	void UnregisterTickBalanceProxy(BalanceTickObjectProxy proxy);
	void DeallocateTickBalanceProxy<T>(ref T proxy, bool bForceDeallocate)
		where T : BalanceTickObjectProxy;
	void RefreshMainCameraMatrixUnityThread(Camera InCamera);
	void UpdateComputeThread(float inGlobalTime, float deltaTime);
	void OnJobFlushEveryFrame();
	void Flush();
	void CollectDataUnityThread();
}

