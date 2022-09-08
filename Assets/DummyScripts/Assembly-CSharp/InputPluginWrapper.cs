/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class InputPluginWrapper // TypeDefIndex: 29973
{
	// Fields
	private InputJoypadType _currControllerType; // 0x10
	protected InputJoypadType _joypadIconDisplayType; // 0x14

	// Properties
	public virtual bool isReady { /* [XID] */ /* 0x00000001898C5520-0x00000001898C5540 */ get => default; } // 0x00000001814D92B0-0x00000001814D9350 
	public InputJoypadType currControllerType { /* [XID] */ /* 0x00000001898E3800-0x00000001898E3820 */ get => default; /* [XID] */ /* 0x00000001898EB480-0x00000001898EB4A0 */ protected set {} } // 0x00000001814D93F0-0x00000001814D9490 0x00000001814D9680-0x00000001814D9840

	// Constructors
	public InputPluginWrapper() {} // 0x00000001814D9A50-0x00000001814D9AC0

	// Methods
	// [XID] // 0x00000001898BDC40-0x00000001898BDC60
	public virtual void Init() {} // 0x00000001814D9350-0x00000001814D93F0
	// [XID] // 0x00000001898CCA60-0x00000001898CCA80
	public virtual void Setup() {} // 0x00000001814D90A0-0x00000001814D9140
	// [XID] // 0x00000001898D4480-0x00000001898D44A0
	public virtual void Update() {} // 0x00000001814D9490-0x00000001814D9530
	// [XID] // 0x00000001898DBC80-0x00000001898DBCA0
	public virtual void Destroy() {} // 0x00000001814D9000-0x00000001814D90A0
	// [XID] // 0x00000001898F2BA0-0x00000001898F2BC0
	public void UpdateJoypadIconDisplayType() {} // 0x00000001814D95D0-0x00000001814D9680
	// [XID] // 0x00000001898FA3B0-0x00000001898FA3D0
	public virtual bool GetButton(InputActionType actionType) => default; // 0x00000001814D99A0-0x00000001814D9A50
	// [XID] // 0x0000000189901D40-0x0000000189901D60
	public virtual float GetOneAxisValue(InputActionType actionType) => default; // 0x00000001814D8F40-0x00000001814D9000
	// [XID] // 0x00000001899095B0-0x00000001899095D0
	public virtual List<KeyCode> GetKeyboardMouseMap(InputActionType inputAction) => default; // 0x00000001814D9840-0x00000001814D98F0
	// [IDTag] // 0x00000001899109E0-0x0000000189910A20
	// [XID] // 0x00000001899109E0-0x0000000189910A20
	public virtual void Vibrate(float intensity) {} // 0x00000001814D9140-0x00000001814D91F0
	// [IDTag] // 0x000000018991B840-0x000000018991B880
	// [XID] // 0x000000018991B840-0x000000018991B880
	public virtual void Vibrate(float left, float right) {} // 0x00000001814D91F0-0x00000001814D92B0
	// [XID] // 0x0000000189925FF0-0x0000000189926010
	public virtual void StopVibration() {} // 0x00000001814D9530-0x00000001814D95D0
	// [XID] // 0x000000018992D620-0x000000018992D640
	public virtual void InitBinding(InputDeviceType deviceType) {} // 0x00000001814D98F0-0x00000001814D99A0
}

