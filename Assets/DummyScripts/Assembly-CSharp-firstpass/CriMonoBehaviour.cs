/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public abstract class CriMonoBehaviour : MonoBehaviour // TypeDefIndex: 7246
{
	// Properties
	public Guid guid { get; private set; } // 0x00000001864439B0-0x0000000186443A20 0x0000000186443A20-0x0000000186443A90

	// Constructors
	public CriMonoBehaviour() {} // 0x00000001864438D0-0x00000001864439B0

	// Methods
	protected virtual void OnEnable() {} // 0x0000000186443830-0x00000001864438D0
	protected virtual void OnDisable() {} // 0x00000001864437A0-0x0000000186443830
	public abstract void CriInternalUpdate();
	public abstract void CriInternalLateUpdate();
}

