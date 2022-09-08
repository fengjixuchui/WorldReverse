/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class SingletonStat<T> // TypeDefIndex: 27875
	where T : SingletonStat<T>, new()
{
	// Fields
	private static T _instance;
	protected string sessionID;
	public string lastSnapShot;
	protected string savedSnapShot;
	private float _currentDumpDuation;
	private float _targetDumpDuration;
	private bool _bOnlyOnceDumpDuration;

	// Properties
	public static T instance { get; }

	// Constructors
	protected SingletonStat() {}

	// Methods
	public static void Start(string inSessionID) {}
	public static void Stop() {}
	protected abstract void OnStart(string inSessionID);
	protected abstract void OnStop();
	protected abstract void OnTakeSnapshot(bool bDetailMode);
	public static void TakeSnapShot(bool bDetailMode = false /* Metadata: 0x00B0D0BB */) {}
	protected virtual void OnClearAll() {}
	public static void ClearAll() {}
	public void SetDumpByDuration(float intervalSec, bool bOnlyOnce) {}
	protected void UpdateDumpByDuration(float dt) {}
}

