/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public sealed class Mouse : ControllerWithAxes // TypeDefIndex: 3654
	{
		// Fields
		private TimerAbs mouseAxisPollingTimer; // 0x148
		private float[] cumulativeMousePollingAxes; // 0x150
		private Vector2 _screenPosition; // 0x158
		private Vector2 _screenPositionPrev; // 0x160
		private int _lastScreenPositionUpdateFrame; // 0x168
		private readonly IUnifiedMouseSource _source; // 0x170
		private static Guid s_deviceInstanceGuid; // 0x00
	
		// Properties
		public Vector2 screenPosition { get => default; } // 0x0000000185300E50-0x0000000185300F60 
		public Vector2 screenPositionPrev { get => default; } // 0x0000000185300D40-0x0000000185300E50 
		public Vector2 screenPositionDelta { get => default; } // 0x0000000185300BF0-0x0000000185300D40 
		public override Guid deviceInstanceGuid { get => default; } // 0x0000000185300AD0-0x0000000185300BF0 
	
		// Constructors
		public Mouse() {} // Dummy constructor
		internal Mouse(string name, IUnifiedMouseSource source) {} // 0x00000001853008A0-0x0000000185300AD0
		private Mouse(int controllerId, InputSource inputSource, string name, string hardwareIdentifier, int axisCount, int buttonCount, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater) {} // 0x0000000185300750-0x00000001853008A0
	
		// Methods
		internal override void UpdateData(UpdateLoopType updateLoop) {} // 0x0000000185300680-0x0000000185300750
		protected override bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId) {
			pole = default;
			elementIdentifierId = default;
			return default;
		} // 0x00000001852FFF40-0x0000000185300460
		internal override void Clear() {} // 0x00000001852FFE60-0x00000001852FFF40
		internal override bool SetEnabled(bool state) => default; // 0x00000001853005E0-0x0000000185300680
		private void RecordMouseScreenPosition() {} // 0x0000000185300460-0x00000001853005E0
	}
}
