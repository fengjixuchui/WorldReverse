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
using Rewired.Utils.Classes.Data;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public abstract class ControllerMapWithAxes : ControllerMap // TypeDefIndex: 4136
	{
		// Fields
		private readonly IList<ActionElementMap> yqfwPzXnQCcQWmMZOGXrgztArbHI; // 0x70
		private readonly ReadOnlyCollection<ActionElementMap> HzeXlolQbBeUhGGukIPIfDHuLuc; // 0x78
	
		// Properties
		public int axisMapCount { get; } // 0x0000000185D5E870-0x0000000185D5E950 
		public IList<ActionElementMap> AxisMaps { get; } // 0x0000000185D5E6E0-0x0000000185D5E7C0 
		internal AList<ActionElementMap> AxisMaps_orig { get; } // 0x0000000185D5E7C0-0x0000000185D5E870 
	
		// Constructors
		public ControllerMapWithAxes() {} // 0x0000000185D5E450-0x0000000185D5E530
	
		// Methods
		public override bool ContainsAction(int actionId) => default; // 0x0000000185D5BA20-0x0000000185D5BC10
		public override bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result) {
			result = default;
			return default;
		} // 0x0000000185D5BC10-0x0000000185D5BE40
		public override bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result) {
			result = default;
			return default;
		} // 0x0000000185D5E070-0x0000000185D5E390
		public override bool DeleteElementMap(int elementMapId) => default; // 0x0000000185D5BF00-0x0000000185D5C030
		public override ActionElementMap GetElementMap(int elementMapId) => default; // 0x0000000185D5C8D0-0x0000000185D5CB90
		public override ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps) => default; // 0x0000000185D5D1A0-0x0000000185D5D430
		public override void ClearElementMaps() {} // 0x0000000185D5B930-0x0000000185D5BA20
		public ActionElementMap GetFirstAxisMapWithAction(int actionId) => default; // 0x0000000185D5D0C0-0x0000000185D5D1A0
		public ActionElementMap GetFirstAxisMapWithAction(int actionId, bool skipDisabledMaps) => default; // 0x0000000185D5CE10-0x0000000185D5D0C0
		public override bool DoesElementAssignmentConflict(ActionElementMap actionElementMap, bool skipDisabledMaps) => default; // 0x0000000185D5C3F0-0x0000000185D5C650
		public override bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) => default; // 0x0000000185D5C030-0x0000000185D5C3F0
		public override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) => default; // 0x0000000185D5C650-0x0000000185D5C730
		public override int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) => default; // 0x0000000185D5DC60-0x0000000185D5E070
		internal override bool AddActionMapping_BeforeBake(ActionElementMap param_00008a1f) => default; // 0x0000000185D5B700-0x0000000185D5B800
		internal int gOcKLNtqDSCVlHyLurllgnkHbLHN(int param_00008a20) => default; // 0x0000000185D5E530-0x0000000185D5E6E0
		internal override int GetElementMapsWithAction(int param_00008a21, bool param_00008a22, List<ActionElementMap> param_00008a23, bool param_00008a24) => default; // 0x0000000185D5CB90-0x0000000185D5CE10
		internal override ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget param_00008a25, bool param_00008a26, int param_00008a27, bool param_00008a28, out bool param_00008a29) {
			param_00008a29 = default;
			return default;
		} // 0x0000000185D5D430-0x0000000185D5D950
		internal override bool AddElementMap(ActionElementMap param_00008a2a) => default; // 0x0000000185D5B800-0x0000000185D5B930
		private new bool NazMgzUnvggfOsDycmqIQvTPcxX(ControllerElementType param_00008a2b) => default; // 0x0000000185D5DC00-0x0000000185D5DC60
		private void WuChnzPslaUlmRLIBtQjOWdaOdB(int param_00008a2c, int param_00008a2d) {} // 0x0000000185D5E390-0x0000000185D5E450
		private void wEjrXWgpPemJWXOxgnwHNSDxUZx(ActionElementMap param_00008a2e) {} // 0x0000000185D5E950-0x0000000185D5EB00
		internal override void ExportDataToSerializedObject(SerializedObject param_00008a2f) {} // 0x0000000185D5C730-0x0000000185D5C8D0
		internal override bool Import(SerializedObject param_00008a30) => default; // 0x0000000185D5D950-0x0000000185D5DC00
	}
}
