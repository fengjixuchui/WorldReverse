/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoEffectPluginCameraBlur : BaseMonoEffectPlugin // TypeDefIndex: 19697
	{
		// Fields
		public float power; // 0x28
		public float shakeRange; // 0x2C
		private CameraBlurSource _blurSource; // 0x30
		private int _handle; // 0x38
	
		// Constructors
		public MonoEffectPluginCameraBlur() {} // 0x0000000184E38BE0-0x0000000184E38C70
	
		// Methods
		// [XID] // 0x0000000189940DE0-0x0000000189940E00
		public override void Init() {} // 0x0000000184E38660-0x0000000184E38700
		// [XID] // 0x00000001899487E0-0x0000000189948800
		public override void Tick(float inDeltaTime) {} // 0x0000000184E38A50-0x0000000184E38BE0
		// [XID] // 0x000000018994FF70-0x000000018994FF90
		public override void Enabled() {} // 0x0000000184E38450-0x0000000184E384F0
		// [XID] // 0x0000000189957560-0x0000000189957580
		public override void Disabled() {} // 0x0000000184E383B0-0x0000000184E38450
		// [XID] // 0x000000018995EF70-0x000000018995EF90
		public override void OnEmittingStopped() {} // 0x0000000184E389B0-0x0000000184E38A50
		// [XID] // 0x00000001899667B0-0x00000001899667D0
		private void StartBlur() {} // 0x0000000184E38700-0x0000000184E388F0
		// [XID] // 0x000000018996DC00-0x000000018996DC20
		private void StopBlur() {} // 0x0000000184E38570-0x0000000184E38660
	}
}
