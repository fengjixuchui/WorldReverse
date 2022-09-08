/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public abstract class ControllerWithAxes : ControllerWithMap // TypeDefIndex: 3638
	{
		// Fields
		protected readonly int _axisCount; // 0x100
		protected readonly int _axis2DCount; // 0x104
		protected readonly Axis[] axes; // 0x108
		protected readonly ReadOnlyCollection<Axis> axes_readOnly; // 0x110
		protected readonly Axis2D[] axes2D; // 0x118
		protected readonly ReadOnlyCollection<Axis2D> axes2D_readOnly; // 0x120
		protected CalibrationMap _calibrationMap; // 0x128
		private float[] eqPhHTJPTbZzZjqXRoRXqdDrfNYA; // 0x130
		private uint PHllaUeIdHWbiKlhKBkFgQCtbSWA; // 0x138
		private Func<int, int> SbsjUtjrUKRfhEeDUdLdKfSGtVhl; // 0x140
	
		// Properties
		public int axisCount { get; } // 0x0000000185D66EA0-0x0000000185D66F70 
		public int axis2DCount { get; } // 0x0000000185D66DD0-0x0000000185D66EA0 
		public IList<Axis> Axes { get; } // 0x0000000185D66C00-0x0000000185D66CE0 
		public CalibrationMap calibrationMap { get; } // 0x0000000185D66F70-0x0000000185D67040 
		public IList<ControllerElementIdentifier> AxisElementIdentifiers { get; } // 0x0000000185D66CE0-0x0000000185D66DD0 
	
		// Constructors
		protected ControllerWithAxes() {} // Dummy constructor
		internal ControllerWithAxes(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, ControllerType type, Guid hardwareTypeGuid, int axisCount, int buttonCount, bool[] isButtonPressureSensitive, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater) {} // 0x0000000185D66350-0x0000000185D66C00
	
		// Methods
		public override Element GetElementById(int elementIdentifierId) => default; // 0x0000000185D64CB0-0x0000000185D64E20
		public int GetAxisIndexById(int elementIdentifierId) => default; // 0x0000000185D64A40-0x0000000185D64B30
		public float GetAxisById(int elementIdentifierId) => default; // 0x0000000185D648D0-0x0000000185D64A40
		public float GetAxisRawById(int elementIdentifierId) => default; // 0x0000000185D64B30-0x0000000185D64CB0
		public override float GetLastTimeAnyElementChanged() => default; // 0x0000000185D65120-0x0000000185D651A0
		public override float GetLastTimeAnyElementChanged(bool useRawValues) => default; // 0x0000000185D65010-0x0000000185D65120
		public float GetLastTimeAnyAxisChanged(bool useRawValues) => default; // 0x0000000185D64E20-0x0000000185D65010
		public override IEnumerable<ControllerPollingInfo> PollForAllElementsDown() => default; // 0x0000000185D65640-0x0000000185D656E0
		public IEnumerable<ControllerPollingInfo> PollForAllAxes() => default; // 0x0000000185D655A0-0x0000000185D65640
		private void PwFtNoHlaNYkltznFPguDSluRym() {} // 0x0000000185D656E0-0x0000000185D658F0
		protected virtual bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId) {
			pole = default;
			elementIdentifierId = default;
			return default;
		} // 0x0000000185D652A0-0x0000000185D655A0
		public bool ImportCalibrationMapFromXmlString(string xmlString) => default; // 0x0000000185D651A0-0x0000000185D652A0
		internal override void UpdateData(UpdateLoopType param_0000800a) {} // 0x0000000185D65CF0-0x0000000185D66350
		internal bool RoxnbHmfcMcuGcFEwZyeaMuOhQh(ActionElementMap param_0000800b, int param_0000800c, bool param_0000800d, bool param_0000800e, out float param_0000800f) {
			param_0000800f = default;
			return default;
		} // 0x0000000185D658F0-0x0000000185D65CF0
		internal override void BakeMap(ControllerMap param_00008010) {} // 0x0000000185D645C0-0x0000000185D64750
		internal override void BakeActionElementMap(ControllerMap param_00008011, ActionElementMap param_00008012) {} // 0x0000000185D644D0-0x0000000185D645C0
		internal void vFRIPkHGpMqQFbGcGqqRyxZqUXXX() {} // 0x0000000185D670B0-0x0000000185D67350
		internal override void Clear() {} // 0x0000000185D64750-0x0000000185D648D0
	}
}
