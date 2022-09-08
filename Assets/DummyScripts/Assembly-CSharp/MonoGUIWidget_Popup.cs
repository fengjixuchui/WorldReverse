/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MonoGUIWidget_Popup : MonoBehaviour // TypeDefIndex: 27680
{
	// Fields
	private Popup _popup; // 0x18
	private GUIContent[] _contents; // 0x20
	private GUIStyle _style; // 0x28
	private bool _needSpace; // 0x30
	private int _yOffset; // 0x34
	private string _title; // 0x38
	private string _extensionBtnTitle; // 0x40
	private Action _onClickExtensionBtn; // 0x48
	private Rect _drawRect; // 0x50
	public bool bManualCallDraw; // 0x60

	// Properties
	public string currentContent { get => default; } // 0x0000000181D82E00-0x0000000181D82EC0 
	public Rect parentRect { set {} } // 0x0000000181D82EC0-0x0000000181D82F60

	// Constructors
	public MonoGUIWidget_Popup() {} // 0x0000000181D82D50-0x0000000181D82E00

	// Methods
	public void InitializeExtensionBtn(string inBtnTitle, Action inOnClick) {} // 0x0000000181D82B20-0x0000000181D82BA0
	public T currentEnumContent<T>() => default;
	public MonoGUIWidget_Popup SelectPopup(string content) => default; // 0x0000000181D82C10-0x0000000181D82D50
	private void Awake() {} // 0x0000000181D82610-0x0000000181D826E0
	private void OnGUI() {} // 0x0000000181D82BA0-0x0000000181D82C10
	public void GUIDraw() {} // 0x0000000181D826E0-0x0000000181D82B20
	public static MonoGUIWidget_Popup Initialize<T>(GameObject inGO, string inTitle, IEnumerable<T> inContents, GUIStyle inStyle, int inYOffset, bool bNeedSpace = false /* Metadata: 0x00B0CAB4 */) => default;
}

