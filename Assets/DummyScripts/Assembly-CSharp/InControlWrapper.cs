/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using InControl;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InControlWrapper : InputPluginWrapper // TypeDefIndex: 29972
{
	// Fields
	private const string IN_CONTROL_MANAGER_PREFAB = "ART/UI/UIScene/InControlManager"; // Metadata: 0x00B1039F
	private InControlManager _inControlManager; // 0x18
	private InControlActionSet _actionSet; // 0x20

	// Properties
	public override bool isReady { /* [XID] */ /* 0x000000018986DE30-0x000000018986DE50 */ get => default; } // 0x000000018340BBB0-0x000000018340BC80 

	// Constructors
	public InControlWrapper() {} // 0x000000018340C620-0x000000018340C690

	// Methods
	// [XID] // 0x0000000189866530-0x0000000189866550
	public override void Init() {} // 0x000000018340BC80-0x000000018340BE50
	// [XID] // 0x00000001898751E0-0x0000000189875200
	public override void Setup() {} // 0x000000018340B6F0-0x000000018340B880
	// [XID] // 0x000000018987CE10-0x000000018987CE30
	private void OnDeviceAttached(InputDevice device) {} // 0x000000018340C230-0x000000018340C390
	// [XID] // 0x0000000189883D90-0x0000000189883DB0
	private void OnDeviceDetached(InputDevice device) {} // 0x000000018340B590-0x000000018340B6F0
	// [XID] // 0x000000018988B430-0x000000018988B450
	private void OnActiveDeviceChanged(InputDevice device) {} // 0x000000018340C390-0x000000018340C540
	// [XID] // 0x0000000189892BB0-0x0000000189892BD0
	public override void Update() {} // 0x000000018340BFC0-0x000000018340C060
	// [IDTag] // 0x000000018989A230-0x000000018989A270
	// [XID] // 0x000000018989A230-0x000000018989A270
	public override void Vibrate(float intensity) {} // 0x000000018340B950-0x000000018340BA70
	// [IDTag] // 0x00000001898A4740-0x00000001898A4780
	// [XID] // 0x00000001898A4740-0x00000001898A4780
	public override void Vibrate(float left, float right) {} // 0x000000018340BA70-0x000000018340BBB0
	// [XID] // 0x00000001898AEF40-0x00000001898AEF60
	public override void StopVibration() {} // 0x000000018340C060-0x000000018340C160
	// [XID] // 0x00000001898B63F0-0x00000001898B6410
	public override void InitBinding(InputDeviceType deviceType) {} // 0x000000018340C540-0x000000018340C620
}

