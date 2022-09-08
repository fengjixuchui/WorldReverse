/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriMonoBehaviourManager : MonoBehaviour // TypeDefIndex: 7247
{
	// Fields
	private static CriMonoBehaviourManager _instance; // 0x00
	private static List<CriMonoBehaviour> criMonoBehaviourList; // 0x08

	// Properties
	public static CriMonoBehaviourManager instance { get => default; } // 0x0000000186443710-0x00000001864437A0 

	// Constructors
	public CriMonoBehaviourManager() {} // 0x00000001864436B0-0x0000000186443710
	static CriMonoBehaviourManager() {} // 0x0000000186443610-0x00000001864436B0

	// Methods
	public static void CreateInstance() {} // 0x0000000186442CD0-0x0000000186442DD0
	private static int GetIndex(CriMonoBehaviour criMonoBehaviour) => default; // 0x0000000186442DD0-0x0000000186442F20
	public bool Register(CriMonoBehaviour criMonoBehaviour) => default; // 0x00000001864430E0-0x00000001864432B0
	public static bool UnRegister(CriMonoBehaviour criMonoBehaviour) => default; // 0x00000001864432B0-0x0000000186443450
	private void Awake() {} // 0x0000000186442BA0-0x0000000186442CD0
	private void Update() {} // 0x0000000186443450-0x0000000186443610
	private void LateUpdate() {} // 0x0000000186442F20-0x00000001864430E0
}

