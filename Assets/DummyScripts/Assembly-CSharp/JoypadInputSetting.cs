/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using InControl;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[CreateAssetMenu] // 0x0000000189995470-0x00000001899954B0
public class JoypadInputSetting : ScriptableObject // TypeDefIndex: 19643
{
	// Fields
	[Space] // 0x00000001898E0F50-0x00000001898E0F60
	public string guid; // 0x18
	[SerializeField] // 0x00000001899857A0-0x00000001899857D0
	[Space] // 0x00000001899857A0-0x00000001899857D0
	private ControlElement[] _controlElements; // 0x20

	// Nested types
	[Serializable]
	public struct ControlElement // TypeDefIndex: 19644
	{
		// Fields
		public string name; // 0x00
		public int id; // 0x08
		public InputControlType inputControlType; // 0x0C
		public string spriteName; // 0x10
	}

	// Constructors
	public JoypadInputSetting() {} // 0x0000000183AF2470-0x0000000183AF2510

	// Methods
	public string GetElementIconName(int elementID) => default; // 0x0000000183AF2260-0x0000000183AF2360
	public string GetElementIconName(InputControlType inputControlType) => default; // 0x0000000183AF2360-0x0000000183AF2470
	public string GetElementIconName(string name) => default; // 0x0000000183AF2100-0x0000000183AF2260
}

